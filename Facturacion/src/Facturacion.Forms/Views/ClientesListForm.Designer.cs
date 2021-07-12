
namespace Facturacion.Forms.Views
{
    partial class ClientesListForm
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
            this.CedulaBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SalirButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.ListadoGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LimpiarFiltroButton);
            this.groupBox1.Controls.Add(this.CedulaBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NombreBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // LimpiarFiltroButton
            // 
            this.LimpiarFiltroButton.Location = new System.Drawing.Point(572, 15);
            this.LimpiarFiltroButton.Name = "LimpiarFiltroButton";
            this.LimpiarFiltroButton.Size = new System.Drawing.Size(92, 23);
            this.LimpiarFiltroButton.TabIndex = 4;
            this.LimpiarFiltroButton.Text = "Limpiar Filtros";
            this.LimpiarFiltroButton.UseVisualStyleBackColor = true;
            this.LimpiarFiltroButton.Click += new System.EventHandler(this.LimpiarFiltroButton_Click);
            // 
            // CedulaBox
            // 
            this.CedulaBox.Location = new System.Drawing.Point(446, 16);
            this.CedulaBox.MaxLength = 16;
            this.CedulaBox.Name = "CedulaBox";
            this.CedulaBox.Size = new System.Drawing.Size(120, 23);
            this.CedulaBox.TabIndex = 3;
            this.CedulaBox.TextChanged += new System.EventHandler(this.OnTextChangedControls);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cedula:";
            // 
            // NombreBox
            // 
            this.NombreBox.Location = new System.Drawing.Point(143, 16);
            this.NombreBox.MaxLength = 256;
            this.NombreBox.Name = "NombreBox";
            this.NombreBox.Size = new System.Drawing.Size(244, 23);
            this.NombreBox.TabIndex = 1;
            this.NombreBox.TextChanged += new System.EventHandler(this.OnTextChangedControls);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre/Razon Social:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SalirButton);
            this.panel1.Controls.Add(this.EliminarButton);
            this.panel1.Controls.Add(this.ModificarButton);
            this.panel1.Controls.Add(this.AgregarButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 411);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 50);
            this.panel1.TabIndex = 1;
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(544, 12);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(120, 24);
            this.SalirButton.TabIndex = 3;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(344, 12);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(200, 24);
            this.EliminarButton.TabIndex = 2;
            this.EliminarButton.Text = "Eliminar Clientes Seleccionados";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Location = new System.Drawing.Point(152, 12);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(192, 24);
            this.ModificarButton.TabIndex = 1;
            this.ModificarButton.Text = "Modificar Cliente Seleccionado";
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(24, 12);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(128, 24);
            this.AgregarButton.TabIndex = 0;
            this.AgregarButton.Text = "Agregar Cliente";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // ListadoGrid
            // 
            this.ListadoGrid.AllowUserToAddRows = false;
            this.ListadoGrid.AllowUserToDeleteRows = false;
            this.ListadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListadoGrid.Location = new System.Drawing.Point(0, 48);
            this.ListadoGrid.Name = "ListadoGrid";
            this.ListadoGrid.ReadOnly = true;
            this.ListadoGrid.RowTemplate.Height = 25;
            this.ListadoGrid.Size = new System.Drawing.Size(684, 363);
            this.ListadoGrid.TabIndex = 2;
            // 
            // ClientesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.ListadoGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClientesListForm";
            this.Text = "Listado de Clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CedulaBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ListadoGrid;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button LimpiarFiltroButton;
    }
}