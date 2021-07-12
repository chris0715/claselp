using Facturacion.Core.Entities;
using System.Windows.Forms;

namespace Facturacion.Forms.Views
{
    public partial class UsuarioForm : Form
    {
        public User Result { get; private set; }

        public UsuarioForm(User user)
        {
            InitializeComponent();
            Text = (Result is null ? "Crear" : "Modificar") + " Usuario";
            Result = user ?? new User();
            UsernameBox.Text = Result.Username;
            PasswordBox.Text = Result.Password;
            ActiveBox.Checked = Result.Active;
        }

        private void UsernameBox_TextChanged(object sender, System.EventArgs e) =>
            Result.Username = UsernameBox.Text;

        private void PasswordBox_TextChanged(object sender, System.EventArgs e) =>
            Result.Password = PasswordBox.Text;

        private void FullNameBox_TextChanged(object sender, System.EventArgs e) =>
            Result.Name = FullNameBox.Text;

        private void ActiveBox_CheckedChanged(object sender, System.EventArgs e) =>
            Result.Active = ActiveBox.Checked;

        private void CreateButton_Click(object sender, System.EventArgs e)
        {
            var result = DialogResult.OK;

            if (UsernameBox.Text.Trim().Length == 0)
            {
                UsernameBox.Focus();
                result = DialogResult.None;
            }
            else if (PasswordBox.Text.Length == 0)
            {
                PasswordBox.Focus();
                result = DialogResult.None;
            }
            else if (FullNameBox.Text.Trim().Length == 0)
            {
                FullNameBox.Focus();
                result = DialogResult.None;
            }

            DialogResult = result;
        }
    }
}
