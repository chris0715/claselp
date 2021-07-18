using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Facturacion.Core.Services;

namespace Facturacion.Forms.Views
{
    public partial class MainForm : Form
    {
        private readonly AuthService _authService;
        private readonly IServiceProvider _serviceProvider;

        #region Helpers
        private void CloseAllChildrens()
        {
            foreach (var children in MdiChildren)
                children.Close();
        }

        private void ResetTopMenuEntries()
        {
            VendedoresMenu.Enabled = true;
            ClientesMenu.Enabled = true;
            ArticulosMenu.Enabled = true;
            FacturacionMenu.Enabled = true;
            ReportesMenu.Enabled = true;
            UsuariosMenu.Enabled = true;
        }

        private void DisableTopMenuEntries()
        {
            if (!_authService.CurrentUser.IsAdmin)
            {
                VendedoresMenu.Enabled = false;
                ArticulosMenu.Enabled = false;
                UsuariosMenu.Enabled = false;
            }
        }

        private void Login()
        {
            ResetTopMenuEntries();

            var loginDialog = _serviceProvider.GetService<LoginForm>();
            if (loginDialog.ShowDialog(this) == DialogResult.Cancel)
                Environment.Exit(0);

            DisableTopMenuEntries();
        }

        private void Logout()
        {
            CloseAllChildrens();
            _authService.Logout();
        }
        #endregion

        #region Control Events
        private void CerrarSesionMenu_Click(object sender, EventArgs e)
        {
            Logout();
            Login();
        }
        #endregion

        protected override void OnShown(EventArgs e) => Login();

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Desea cerrar el sistema?", "Salir del Sistema",
                                         MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Environment.Exit(0);
            e.Cancel = true;
        }

        #region Menu Events
        private void ShowForm(Form form)
        {
            form.MdiParent = this;
            ActivateMdiChild(form);
            form.Show();
        }

        private void NuevoVendedorButton_Click(object sender, EventArgs e) =>
          _serviceProvider.GetService<VendedoresListForm>().AgregarButton_Click(this, new EventArgs());

        private void VendedoresListButton_Click(object sender, EventArgs e) =>
            ShowForm(_serviceProvider.GetService<VendedoresListForm>());
        
        private void ClientesListButton_Click(object sender, EventArgs e) =>
            ShowForm(_serviceProvider.GetService<ClientesListForm>());
        
        private void ArticuloListButton_Click(object sender, EventArgs e) =>
            ShowForm(_serviceProvider.GetService<ArticulosListForm>());

        private void FacturaListButton_Click(object sender, EventArgs e) =>
            ShowForm(_serviceProvider.GetService<FacturasListForm>());

        private void UsuarioListButton_Click(object sender, EventArgs e) =>
            ShowForm(_serviceProvider.GetService<UsuariosListForm>());

        private void NuevoUsuarioButton_Click(object sender, EventArgs e) =>
            _serviceProvider.GetService<UsuariosListForm>().CrearButton_Click(this, new EventArgs());

        private void NuevoClienteButton_Click(object sender, EventArgs e) =>
            _serviceProvider.GetService<ClientesListForm>().AgregarButton_Click(this, new EventArgs());

        private void NuevoArticuloButton_Click(object sender, EventArgs e) =>
            _serviceProvider.GetService<ArticulosListForm>().CrearButton_Click(this, new EventArgs());
        #endregion

        public MainForm(IServiceProvider serviceProvider, AuthService authService)
        {
            _serviceProvider = serviceProvider;
            _authService = authService;
            InitializeComponent();
        }
    }
}
