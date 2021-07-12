using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Facturacion.Core.Services;

namespace Facturacion.Forms.Views
{
    public partial class ArticulosListForm : FormBase
    {
        private readonly ItemsService _itemsService;

        private async void UpdateAndRefreshData()
        {
            ListadoGrid.DataSource = await _itemsService.GetItems(DescripcionBox.Text.Trim());
            ListadoGrid.Update();
            ListadoGrid.Refresh();
        }

        protected override void OnActivated(EventArgs e) =>
            UpdateAndRefreshData();

        private void OnTextChangedControls(object sender, EventArgs e) =>
            UpdateAndRefreshData();

        public ArticulosListForm(ItemsService itemsService) : base() 
        { 
            InitializeComponent();
            _itemsService = itemsService;
        }

        public async void CrearButton_Click(object sender, EventArgs e)
        {
            bool created = false;
            var form = new ArticuloForm(null);

            while (!created)
            {
                var result = form.ShowDialog();
                switch (result)
                {
                    case DialogResult.OK:
                        {
                            created = await _itemsService.CreateItem(form.Result);
                            if (!created)
                                MessageBox.Show(this, "Fallo al crear registro.", "Creacion de Registro");
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

            int itemId = (int)ListadoGrid.Rows[ListadoGrid.SelectedCells[0].RowIndex].Cells["Id"].Value;
            bool updated = false;
            var form = new ArticuloForm(await _itemsService.GetItem(itemId));
            while (!updated)
            {
                var result = form.ShowDialog();
                switch (result)
                {
                    case DialogResult.OK:
                        {
                            updated = await _itemsService.UpdateItem(form.Result);
                            if (!updated)
                                MessageBox.Show(this, "Fallo al actualizar el registro.", "Creacion de Registro");
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
                    await _itemsService.DeleteItem((int)row.Cells["Id"].Value);

                UpdateAndRefreshData();
            }
        }

        private void SalirButton_Click(object sender, EventArgs e) => Hide();

        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            DescripcionBox.Clear();
            DescripcionBox.Focus();
            UpdateAndRefreshData();
        }
    }
}
