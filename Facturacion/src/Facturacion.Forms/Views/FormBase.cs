using Facturacion.Core;
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
    public partial class FormBase : Form
    {
        private void CancelClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        protected override void OnClosing(CancelEventArgs e) => CancelClosing(e);

        protected override void OnFormClosing(FormClosingEventArgs e) => CancelClosing(e);

        public FormBase() => InitializeComponent();

        public void InitComboBoxFieldInfoCore(ComboBox comboBox, List<FieldInfoCore> rows)
        {
            if(rows != null)
            {
                comboBox.Items.AddRange(rows.ToArray());
            }
            comboBox.DisplayMember = nameof(FieldInfoCore.Label);
            comboBox.ValueMember = nameof(FieldInfoCore.DbColumnName);
        }

        public void CargarRegistrosPorDbPropiedad(FieldInfoCore prop, string propertyVal, DataGridView gridView, Func<string,string, object> searchMethod)
        {

            if (prop == null)
            {
                gridView.DataSource = searchMethod(null, null);
            } else
            {
                gridView.DataSource = searchMethod(prop.DbColumnName, propertyVal);
            }
            
            gridView.Update();
            gridView.Refresh();
        }
    }
}
