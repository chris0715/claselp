using System;
using System.ComponentModel;
using System.Windows.Forms;
using Facturacion.Core.Entities;
using Facturacion.Core.Services;

namespace Facturacion.Forms.Views
{
    public partial class LoginForm : Form
    {
        private readonly AuthService _authService;

        protected override void OnShown(EventArgs e)
        {
            UsernameBox.Clear();
            PasswordBox.Clear();
            UsernameBox.Focus();
        }

        #region Helpers
        private async void HandleLogin()
        {
            if (UsernameBox.Text.Length == 0)
            {
                UsernameBox.Focus();
                DialogResult = DialogResult.None;
                return;
            }

            if (PasswordBox.Text.Length == 0)
            {
                PasswordBox.Focus();
                DialogResult = DialogResult.None;
                return;
            }

            var result = await _authService.Login(UsernameBox.Text.Trim(), PasswordBox.Text);
            if (result != LoginResult.Success)
            {
                switch (result)
                {
                    case LoginResult.InvalidUsername: UsernameBox.Focus(); break;
                    case LoginResult.InvalidPassword: PasswordBox.Focus(); break;
                }

                MessageBox.Show(result.GetDescription());
                DialogResult = DialogResult.None;
                return;
            }

            DialogResult = DialogResult.OK;
        }
        #endregion

        #region Control Events
        private void LoginButton_Click(object sender, EventArgs e) => HandleLogin();
        #endregion

        public LoginForm(AuthService authService)
        {
            _authService = authService;
            InitializeComponent();
        }
    }
}
