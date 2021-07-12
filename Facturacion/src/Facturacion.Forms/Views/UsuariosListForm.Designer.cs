
namespace Facturacion.Forms.Views
{
    partial class UsuariosListForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LimpiarFiltroButton = new System.Windows.Forms.Button();
            this.EstadoBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SalirButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.CrearButton = new System.Windows.Forms.Button();
            this.ListadoGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LimpiarFiltroButton);
            this.groupBox1.Controls.Add(this.EstadoBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NombreBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // LimpiarFiltroButton
            // 
            this.LimpiarFiltroButton.Location = new System.Drawing.Point(678, 16);
            this.LimpiarFiltroButton.Name = "LimpiarFiltroButton";
            this.LimpiarFiltroButton.Size = new System.Drawing.Size(108, 23);
            this.LimpiarFiltroButton.TabIndex = 4;
            this.LimpiarFiltroButton.Text = "Limpiar Filtros";
            this.LimpiarFiltroButton.UseVisualStyleBackColor = true;
            this.LimpiarFiltroButton.Click += new System.EventHandler(this.LimpiarFiltroButton_Click);
            // 
            // EstadoBox
            // 
            this.EstadoBox.FormattingEnabled = true;
            this.EstadoBox.Items.AddRange(new object[] {
            "Todos",
            "Activo",
            "Inactivo"});
            this.EstadoBox.Location = new System.Drawing.Point(563, 16);
            this.EstadoBox.Name = "EstadoBox";
            this.EstadoBox.Size = new System.Drawing.Size(109, 23);
            this.EstadoBox.TabIndex = 3;
            this.EstadoBox.SelectedIndexChanged += new System.EventHandler(this.EstadoBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado:";
            // 
            // NombreBox
            // 
            this.NombreBox.Location = new System.Drawing.Point(131, 16);
            this.NombreBox.MaxLength = 20;
            this.NombreBox.Name = "NombreBox";
            this.NombreBox.Size = new System.Drawing.Size(375, 23);
            this.NombreBox.TabIndex = 1;
            this.NombreBox.TextChanged += new System.EventHandler(this.NombreBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Usuario:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SalirButton);
            this.panel1.Controls.Add(this.EliminarButton);
            this.panel1.Controls.Add(this.ModificarButton);
            this.panel1.Controls.Add(this.CrearButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 413);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 37);
            this.panel1.TabIndex = 1;
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(656, 6);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(130, 23);
            this.SalirButton.TabIndex = 3;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(428, 6);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(190, 23);
            this.EliminarButton.TabIndex = 2;
            this.EliminarButton.Text = "Eliminar Seleccion";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Location = new System.Drawing.Point(200, 6);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(190, 23);
            this.ModificarButton.TabIndex = 1;
            this.ModificarButton.Text = "Modificar Usuario Seleccionado";
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // CrearButton
            // 
            this.CrearButton.Location = new System.Drawing.Point(12, 6);
            this.CrearButton.Name = "CrearButton";
            this.CrearButton.Size = new System.Drawing.Size(150, 23);
            this.CrearButton.TabIndex = 0;
            this.CrearButton.Text = "Crear Nuevo Usuario";
            this.CrearButton.UseVisualStyleBackColor = true;
            this.CrearButton.Click += new System.EventHandler(this.CrearButton_Click);
            // 
            // ListadoGrid
            // 
            this.ListadoGrid.AllowUserToAddRows = false;
            this.ListadoGrid.AllowUserToDeleteRows = false;
            this.ListadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListadoGrid.Location = new System.Drawing.Point(0, 50);
            this.ListadoGrid.Name = "ListadoGrid";
            this.ListadoGrid.ReadOnly = true;
            this.ListadoGrid.RowTemplate.Height = 25;
            this.ListadoGrid.Size = new System.Drawing.Size(800, 363);
            this.ListadoGrid.TabIndex = 2;
            // 
            // UsuariosListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListadoGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "UsuariosListForm";
            this.Text = "Listado de Usuarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox EstadoBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button CrearButton;
        private System.Windows.Forms.DataGridView ListadoGrid;
        private System.Windows.Forms.Button LimpiarFiltroButton;
    }
}