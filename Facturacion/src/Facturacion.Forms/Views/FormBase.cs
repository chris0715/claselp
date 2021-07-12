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
    }
}
