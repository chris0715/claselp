using System;
using System.Linq;
using System.Windows.Forms;
using Facturacion.Core.Services;

namespace Facturacion.Forms.Views
{
    public partial class ClientesListForm : FormBase
    {
        private readonly CustomersService _customerService;

        private async void UpdateAndRefreshData()
        {
            ListadoGrid.DataSource = await _customerService.GetCustomers(NombreBox.Text.Trim(), CedulaBox.Text.Trim());
            ListadoGrid.Update();
            ListadoGrid.Refresh();
        }

        public ClientesListForm(CustomersService customerService) : base()
        {
            InitializeComponent();
            _customerService = customerService;
            this.simpleComboBox.Items.AddRange(_customerService.FieldsMeta.Keys.ToArray());
        }

        private void SalirButton_Click(object sender, EventArgs e) => Hide();

        private void OnTextChangedControls(object sender, EventArgs e) =>
            UpdateAndRefreshData();

        protected override void OnActivated(EventArgs e) =>
            UpdateAndRefreshData();

        public async void AgregarButton_Click(object sender, EventArgs e)
        {
            bool created = false;
            var form = new ClienteForm(null);

            while (!created)
            {
                var result = form.ShowDialog();
                switch (result)
                {
                    case DialogResult.OK:
                        {
                            created = await _customerService.CreateCustomer(form.Result);
                            if (!created)
                                MessageBox.Show(this, "Cliente ya existe, intente con otra cedula.", "Creacion de Registro");
                        }
                        break;
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

            int customerId = (int)ListadoGrid.Rows[ListadoGrid.SelectedCells[0].RowIndex].Cells["Id"].Value;
            bool updated = false;
            var form = new ClienteForm(await _customerService.GetCustomer(customerId));
            while (!updated)
            {
                var result = form.ShowDialog();
                switch (result)
                {
                    case DialogResult.OK:
                        {
                            updated = await _customerService.UpdateCustomer(form.Result);
                            if (!updated)
                                MessageBox.Show(this, "Cliente ya existe, intente con otra cedula.", "Creacion de Registro");
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
            if (MessageBox.Show("Desea eliminar los registros seleccionados?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var selectedRows = ListadoGrid.SelectedCells.Cast<DataGridViewCell>().Select(cell => cell.OwningRow)
                                                .Distinct();
                foreach (var row in selectedRows)
                    await _customerService.DeleteCustomer((int)row.Cells["Id"].Value);

                UpdateAndRefreshData();
            }
        }

        private void LimpiarFiltroButton_Click(object sender, EventArgs e)
        {
            NombreBox.Clear();
            CedulaBox.Clear();
            UpdateAndRefreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListadoGrid.DataSource = _customerService.GetCustomerBy(this.simpleComboBox.SelectedItem.ToString(), this.simpleInput.Text);
            ListadoGrid.Update();
            ListadoGrid.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
