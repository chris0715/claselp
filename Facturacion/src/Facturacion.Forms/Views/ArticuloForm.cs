using Facturacion.Core.Entities;
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
    public partial class ArticuloForm : Form
    {
        public Item Result { get; private set; } 

        public ArticuloForm(Item item)
        {
            InitializeComponent();
            Text = (item is null ? "Nuevo" : "Modificar") + " Articulo";
            Result = item ?? new Item();
            ActivoBox.Checked = Result.Active;
            PriceBox.Text = Result.Price.ToString();
            CostBox.Text = Result.Cost.ToString();
            DescriptionBox.Text = Result.Description;
            StockBox.Text = Result.Stock.ToString();
        }

        private void CostBox_TextChanged(object sender, EventArgs e) =>
            Result.Cost = double.TryParse(CostBox.Text, out var value) ? value : 0;

        private void PriceBox_TextChanged(object sender, EventArgs e) =>
            Result.Price = double.TryParse(PriceBox.Text, out var value)? value: 0;

        private void StockBox_TextChanged(object sender, EventArgs e) =>
            Result.Stock = int.TryParse(StockBox.Text, out var value) ? value : 0;

        private void ActivoBox_CheckedChanged(object sender, EventArgs e) =>
            Result.Active = ActivoBox.Checked;

        private void DescriptionBox_TextChanged(object sender, EventArgs e) =>
            Result.Description = DescriptionBox.Text.Trim();

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            var result = DialogResult.OK;

            if (string.IsNullOrEmpty(DescriptionBox.Text))
            {
                DescriptionBox.Focus();
                MessageBox.Show("Descripcion esta vacia.");
                result = DialogResult.None;
            }
            else if (string.IsNullOrEmpty(PriceBox.Text) || !double.TryParse(PriceBox.Text, out _))
            {
                PriceBox.Focus();
                MessageBox.Show("Precio unitario esta vacio o es invalido.");
                result = DialogResult.None;
            }
            else if (string.IsNullOrEmpty(CostBox.Text) || !double.TryParse(CostBox.Text, out _))
            {
                CostBox.Focus();
                MessageBox.Show("Costo unitario esta vacio o es invalido.");
                result = DialogResult.None;
            }
            else if (string.IsNullOrEmpty(StockBox.Text) || !int.TryParse(StockBox.Text, out _))
            {
                StockBox.Focus();
                MessageBox.Show("Unidades disponibles esta vacio o es invalido.");
                result = DialogResult.None;
            }

            DialogResult = result;
        }
    }
}
