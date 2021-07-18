using System;
using System.Windows.Forms;
using Facturacion.Core.Entities;
using Facturacion.Core.Services;

namespace Facturacion.Forms.Views
{
    public partial class ClienteForm : Form
    {
        public Customer Result { get; private set; }

        public ClienteForm(Customer customer) 
        {
            InitializeComponent();
            Result = customer ?? new Customer();
            NombreBox.Text = Result.FullName;
            CedulaBox.Text = Result.GvmtId;
            ActivoBox.Checked = Result.Active;
            Text = (customer is object ? "Modificar" : "Nuevo") + " Cliente";
        }

        private void NombreBox_TextChanged(object sender, EventArgs e) =>
            Result.FullName = NombreBox.Text;

        private void CedulaBox_TextChanged(object sender, EventArgs e) =>
            Result.GvmtId = CedulaBox.Text;

        private void ActivoBox_CheckedChanged(object sender, EventArgs e) =>
            Result.Active = ActivoBox.Checked;

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            var result = DialogResult.OK;

            if (Result.GvmtId?.Contains("-") ?? false)
                Result.GvmtId = Result.GvmtId.Replace("-", "");

            if (NombreBox.Text.Trim().Length == 0)
            {
                NombreBox.Focus();
                result = DialogResult.None;
            }
            else if (CedulaBox.Text.Length == 0)
            {
                CedulaBox.Focus();
                result = DialogResult.None;
            } else if (!CustomersService.ValidarCedula(Result.GvmtId.Trim()))
            {
                MessageBox.Show("Cedula Invalida");
            }

            DialogResult = result;
        }
    }
}
