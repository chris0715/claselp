using Facturacion.Core;
using Facturacion.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion.Forms.Views
{
    public partial class VendedoresListForm : FormBase
    {
        private SellerService _sellerService;
        
        public VendedoresListForm() : base()
        {
            
            InitializeComponent();
        }


        private async void UpdateAndRefreshData()
        {
            this.CargarRegistrosPorDbPropiedad(this.simpleComboBox.SelectedItem as FieldDropdown, this.simpleInput.Text,
                this.ListadoGrid, _sellerService.GetSellers);
        }


        public List<FieldDropdown> FieldDropdowns = new List<FieldDropdown>() {

            new FieldDropdown { Label= "Nombre & Apellido", DbColumnName = "FullName" },
            new FieldDropdown { Label= "Comision", DbColumnName = "Commission" },
            new FieldDropdown { Label= "Active", DbColumnName = "Active" },
        };

        public VendedoresListForm(SellerService sellerService) : base()
        {
            InitializeComponent();
            _sellerService = sellerService;
            this.InitComboBoxFieldInfoCore(this.simpleComboBox, FieldDropdowns);
        }

        private void SalirButton_Click(object sender, EventArgs e) => Hide();

        private void OnTextChangedControls(object sender, EventArgs e) =>
            UpdateAndRefreshData();

        protected override void OnActivated(EventArgs e) =>
            UpdateAndRefreshData();


      
        public async void AgregarButton_Click(object sender, EventArgs e)
        {
            bool created = false;
            var form = new VendedorForm(null);

            while (!created)
            {
                var result = form.ShowDialog();
                switch (result)
                {
                    case DialogResult.OK:
                        {
                            created = await _sellerService.CreateSeller(form.Result);
                            if (!created)
                                MessageBox.Show(this, "Error al intentar crear vendedor", "Creacion de Vendedor");
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
            var form = new VendedorForm(await _sellerService.GetSeller(customerId));
            while (!updated)
            {
                var result = form.ShowDialog();
                switch (result)
                {
                    case DialogResult.OK:
                        {
                            updated = await _sellerService.UpdateSeller(form.Result);
                            if (!updated)
                                MessageBox.Show(this, "Error al intentar crear vendedor", "Creacion de Vendedor");
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
                    await _sellerService.DeleteSeller((int)row.Cells["Id"].Value);

                UpdateAndRefreshData();
            }
        }

        private void LimpiarFiltroButton_Click(object sender, EventArgs e)
        {
            this.simpleComboBox.SelectedIndex = 0;
            this.simpleInput.Text = "";
            UpdateAndRefreshData();
        }




    }
}
