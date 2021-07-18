using System;
using System.Windows.Forms;
using Facturacion.Core.Entities;

namespace Facturacion.Forms.Views
{
    public partial class VendedorForm : Form
    {
        public Seller Result { get; private set; }

        public VendedorForm(Seller record) 
        {
            InitializeComponent();
            Result = record ?? new Seller();
            NombreBox.Text = Result.FullName;
            ComisionBox.Text = Result.Commission.ToString();
            ActivoBox.Checked = Result.Active;
            Text = (record is object ? "Modificar" : "Nuevo") + " Vendedor";
        }

        private void NombreBox_TextChanged(object sender, EventArgs e) =>
            Result.FullName = NombreBox.Text;

        private void Comision_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void ActivoBox_CheckedChanged(object sender, EventArgs e) =>
            Result.Active = ActivoBox.Checked;

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            var result = DialogResult.OK;

            if (NombreBox.Text.Trim().Length == 0)
            {
                NombreBox.Focus();
                result = DialogResult.None;
            }
            else if (ComisionBox.Text.Length == 0)
            {
                ComisionBox.Focus();
                result = DialogResult.None;
            }

            if (NombreBox.Text.Trim().Length < 2)
            {
                MessageBox.Show("Nombre & apellido debe de contener al menos 2 caracteres");
                result = DialogResult.None;
            }

            Result.Commission = (double)ComisionBox.Value;
            if (Result.Commission <= 0)
            {
                MessageBox.Show("Comission debe ser mayor o igual a 0");
                result = DialogResult.None;
            }

            DialogResult = result;
        }
    }
}
