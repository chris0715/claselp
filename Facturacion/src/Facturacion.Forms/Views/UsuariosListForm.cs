using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Facturacion.Core.Services;
using System.Linq;

namespace Facturacion.Forms.Views
{
    public partial class UsuariosListForm : FormBase
    {
        private readonly UsersService _userService;

        private async void UpdateAndRefreshData()
        {
            var name = NombreBox.Text.Trim();
            name = name.Length == 0 ? null : name;
            bool? selectedIndex = EstadoBox.SelectedIndex switch { 
                1 => true, 2 => false, _ => null 
            };

            ListadoGrid.DataSource = await _userService.GetUsers(name, selectedIndex);
            ListadoGrid.Update();
            ListadoGrid.Refresh();
        }

        protected override void OnActivated(EventArgs e) =>
            UpdateAndRefreshData();

        public UsuariosListForm(UsersService usersService) : base()
        {
            _userService = usersService;
            InitializeComponent();
        }

        private void NombreBox_TextChanged(object sender, EventArgs e) =>
            UpdateAndRefreshData();

        private void EstadoBox_SelectedIndexChanged(object sender, EventArgs e) =>
            UpdateAndRefreshData();

        private void LimpiarFiltroButton_Click(object sender, EventArgs e)
        {
            NombreBox.Clear();
            EstadoBox.SelectedIndex = 0;
            UpdateAndRefreshData();
        }

        public async void CrearButton_Click(object sender, EventArgs e)
        {
            bool created = false;
            var form = new UsuarioForm(null);

            while (!created)
            {
                var result = form.ShowDialog();
                switch (result)
                {
                    case DialogResult.OK:
                    {
                        created = await _userService.CreateUser(form.Result);
                        if (!created)
                            MessageBox.Show(this, "Nombre de usuario ya existe, intente con otro.", "Creacion de Registro");
                    } break;
                    case DialogResult.Cancel:
                        return;
                }
            }
            UpdateAndRefreshData();
        }

        private async void ModificarButton_Click(object sender, EventArgs e)
        {
            if (ListadoGrid.SelectedCells.Count > 1)
            {
                MessageBox.Show("Debe seleccionar solo una fila o columna para modificar.");
                return;
            }

            int userId = (int)ListadoGrid.Rows[ListadoGrid.SelectedCells[0].RowIndex].Cells["Id"].Value;
            bool updated = false;
            var form = new UsuarioForm(await _userService.GetUser(userId));
            while (!updated)
            {
                var result = form.ShowDialog();
                switch (result)
                {
                    case DialogResult.OK:
                        {
                            updated = await _userService.UpdateUser(form.Result);
                            if (!updated)
                                MessageBox.Show(this, "Nombre de usuario ya existe, intente con otro.", "Creacion de Registro");
                        }
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }
            UpdateAndRefreshData();
        }

        private async void EliminarButton_Click(object sender, EventArgs e)
        {
            var selectedRows = ListadoGrid.SelectedCells.Cast<DataGridViewCell>().Select(cell => cell.OwningRow)
                                                        .Distinct();
            foreach (var row in selectedRows)
                await _userService.DeleteUser((int)row.Cells["Id"].Value);

            UpdateAndRefreshData();
        }

        private void SalirButton_Click(object sender, EventArgs e) => Hide();
    }
}
