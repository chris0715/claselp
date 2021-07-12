
namespace Facturacion.Forms.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.VendedoresMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NuevoVendedorButton = new System.Windows.Forms.ToolStripMenuItem();
            this.VendedorListButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NuevoClienteButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientesListButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ArticulosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NuevoArticuloButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ArticuloListButton = new System.Windows.Forms.ToolStripMenuItem();
            this.FacturacionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NuevaFacturaButton = new System.Windows.Forms.ToolStripMenuItem();
            this.FacturaListButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.metodosDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.condicionesDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TotalVentasButton = new System.Windows.Forms.ToolStripMenuItem();
            this.VentasPorClienteButton = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuariosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NuevoUsuarioButton = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuarioListButton = new System.Windows.Forms.ToolStripMenuItem();
            this.CerrarSesionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VendedoresMenu,
            this.ClientesMenu,
            this.ArticulosMenu,
            this.FacturacionMenu,
            this.ReportesMenu,
            this.UsuariosMenu,
            this.CerrarSesionMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // VendedoresMenu
            // 
            this.VendedoresMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoVendedorButton,
            this.VendedorListButton});
            this.VendedoresMenu.Name = "VendedoresMenu";
            this.VendedoresMenu.Size = new System.Drawing.Size(80, 20);
            this.VendedoresMenu.Text = "Vendedores";
            // 
            // NuevoVendedorButton
            // 
            this.NuevoVendedorButton.Name = "NuevoVendedorButton";
            this.NuevoVendedorButton.Size = new System.Drawing.Size(211, 22);
            this.NuevoVendedorButton.Text = "Nuevo Vendedor";
            // 
            // VendedorListButton
            // 
            this.VendedorListButton.Name = "VendedorListButton";
            this.VendedorListButton.Size = new System.Drawing.Size(211, 22);
            this.VendedorListButton.Text = "Ver Listado de Vendedores";
            this.VendedorListButton.Click += new System.EventHandler(this.VendedoresListButton_Click);
            // 
            // ClientesMenu
            // 
            this.ClientesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoClienteButton,
            this.ClientesListButton});
            this.ClientesMenu.Name = "ClientesMenu";
            this.ClientesMenu.Size = new System.Drawing.Size(61, 20);
            this.ClientesMenu.Text = "Clientes";
            // 
            // NuevoClienteButton
            // 
            this.NuevoClienteButton.Name = "NuevoClienteButton";
            this.NuevoClienteButton.Size = new System.Drawing.Size(192, 22);
            this.NuevoClienteButton.Text = "Nuevo Cliente";
            this.NuevoClienteButton.Click += new System.EventHandler(this.NuevoClienteButton_Click);
            // 
            // ClientesListButton
            // 
            this.ClientesListButton.Name = "ClientesListButton";
            this.ClientesListButton.Size = new System.Drawing.Size(192, 22);
            this.ClientesListButton.Text = "Ver Listado de Clientes";
            this.ClientesListButton.Click += new System.EventHandler(this.ClientesListButton_Click);
            // 
            // ArticulosMenu
            // 
            this.ArticulosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoArticuloButton,
            this.ArticuloListButton});
            this.ArticulosMenu.Name = "ArticulosMenu";
            this.ArticulosMenu.Size = new System.Drawing.Size(66, 20);
            this.ArticulosMenu.Text = "Articulos";
            // 
            // NuevoArticuloButton
            // 
            this.NuevoArticuloButton.Name = "NuevoArticuloButton";
            this.NuevoArticuloButton.Size = new System.Drawing.Size(197, 22);
            this.NuevoArticuloButton.Text = "Nuevo Articulo";
            this.NuevoArticuloButton.Click += new System.EventHandler(this.NuevoArticuloButton_Click);
            // 
            // ArticuloListButton
            // 
            this.ArticuloListButton.Name = "ArticuloListButton";
            this.ArticuloListButton.Size = new System.Drawing.Size(197, 22);
            this.ArticuloListButton.Text = "Ver Listado de Articulos";
            this.ArticuloListButton.Click += new System.EventHandler(this.ArticuloListButton_Click);
            // 
            // FacturacionMenu
            // 
            this.FacturacionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevaFacturaButton,
            this.FacturaListButton,
            this.toolStripSeparator1,
            this.metodosDePagoToolStripMenuItem,
            this.condicionesDePagoToolStripMenuItem});
            this.FacturacionMenu.Name = "FacturacionMenu";
            this.FacturacionMenu.Size = new System.Drawing.Size(81, 20);
            this.FacturacionMenu.Text = "Facturacion";
            // 
            // NuevaFacturaButton
            // 
            this.NuevaFacturaButton.Name = "NuevaFacturaButton";
            this.NuevaFacturaButton.Size = new System.Drawing.Size(194, 22);
            this.NuevaFacturaButton.Text = "Nueva Factura";
            // 
            // FacturaListButton
            // 
            this.FacturaListButton.Name = "FacturaListButton";
            this.FacturaListButton.Size = new System.Drawing.Size(194, 22);
            this.FacturaListButton.Text = "Ver Listado de Facturas";
            this.FacturaListButton.Click += new System.EventHandler(this.FacturaListButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // metodosDePagoToolStripMenuItem
            // 
            this.metodosDePagoToolStripMenuItem.Name = "metodosDePagoToolStripMenuItem";
            this.metodosDePagoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.metodosDePagoToolStripMenuItem.Text = "Metodos de Pago";
            // 
            // condicionesDePagoToolStripMenuItem
            // 
            this.condicionesDePagoToolStripMenuItem.Name = "condicionesDePagoToolStripMenuItem";
            this.condicionesDePagoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.condicionesDePagoToolStripMenuItem.Text = "Condiciones de Pago";
            // 
            // ReportesMenu
            // 
            this.ReportesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TotalVentasButton,
            this.VentasPorClienteButton});
            this.ReportesMenu.Name = "ReportesMenu";
            this.ReportesMenu.Size = new System.Drawing.Size(65, 20);
            this.ReportesMenu.Text = "Reportes";
            // 
            // TotalVentasButton
            // 
            this.TotalVentasButton.Name = "TotalVentasButton";
            this.TotalVentasButton.Size = new System.Drawing.Size(169, 22);
            this.TotalVentasButton.Text = "Total de Ventas";
            // 
            // VentasPorClienteButton
            // 
            this.VentasPorClienteButton.Name = "VentasPorClienteButton";
            this.VentasPorClienteButton.Size = new System.Drawing.Size(169, 22);
            this.VentasPorClienteButton.Text = "Ventas por Cliente";
            // 
            // UsuariosMenu
            // 
            this.UsuariosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoUsuarioButton,
            this.UsuarioListButton});
            this.UsuariosMenu.Name = "UsuariosMenu";
            this.UsuariosMenu.Size = new System.Drawing.Size(64, 20);
            this.UsuariosMenu.Text = "Usuarios";
            // 
            // NuevoUsuarioButton
            // 
            this.NuevoUsuarioButton.Name = "NuevoUsuarioButton";
            this.NuevoUsuarioButton.Size = new System.Drawing.Size(195, 22);
            this.NuevoUsuarioButton.Text = "Nuevo Usuario";
            this.NuevoUsuarioButton.Click += new System.EventHandler(this.NuevoUsuarioButton_Click);
            // 
            // UsuarioListButton
            // 
            this.UsuarioListButton.Name = "UsuarioListButton";
            this.UsuarioListButton.Size = new System.Drawing.Size(195, 22);
            this.UsuarioListButton.Text = "Ver Listado de Usuarios";
            this.UsuarioListButton.Click += new System.EventHandler(this.UsuarioListButton_Click);
            // 
            // CerrarSesionMenu
            // 
            this.CerrarSesionMenu.Name = "CerrarSesionMenu";
            this.CerrarSesionMenu.Size = new System.Drawing.Size(88, 20);
            this.CerrarSesionMenu.Text = "Cerrar Sesion";
            this.CerrarSesionMenu.Click += new System.EventHandler(this.CerrarSesionMenu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem VendedoresMenu;
        private System.Windows.Forms.ToolStripMenuItem NuevoVendedorButton;
        private System.Windows.Forms.ToolStripMenuItem VendedorListButton;
        private System.Windows.Forms.ToolStripMenuItem ClientesMenu;
        private System.Windows.Forms.ToolStripMenuItem NuevoClienteButton;
        private System.Windows.Forms.ToolStripMenuItem ClientesListButton;
        private System.Windows.Forms.ToolStripMenuItem ArticulosMenu;
        private System.Windows.Forms.ToolStripMenuItem NuevoArticuloButton;
        private System.Windows.Forms.ToolStripMenuItem ArticuloListButton;
        private System.Windows.Forms.ToolStripMenuItem FacturacionMenu;
        private System.Windows.Forms.ToolStripMenuItem NuevaFacturaButton;
        private System.Windows.Forms.ToolStripMenuItem FacturaListButton;
        private System.Windows.Forms.ToolStripMenuItem ReportesMenu;
        private System.Windows.Forms.ToolStripMenuItem UsuariosMenu;
        private System.Windows.Forms.ToolStripMenuItem CerrarSesionMenu;
        private System.Windows.Forms.ToolStripMenuItem TotalVentasButton;
        private System.Windows.Forms.ToolStripMenuItem VentasPorClienteButton;
        private System.Windows.Forms.ToolStripMenuItem NuevoUsuarioButton;
        private System.Windows.Forms.ToolStripMenuItem UsuarioListButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem metodosDePagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem condicionesDePagoToolStripMenuItem;
    }
}