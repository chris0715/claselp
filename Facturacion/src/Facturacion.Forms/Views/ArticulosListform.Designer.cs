
namespace Facturacion.Forms.Views
{
    partial class ArticulosListForm
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
            this.limpiarFiltroBtn = new System.Windows.Forms.Button();
            this.simpleInput = new System.Windows.Forms.TextBox();
            this.simpleComboBox = new System.Windows.Forms.ComboBox();
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
            this.groupBox1.Controls.Add(this.limpiarFiltroBtn);
            this.groupBox1.Controls.Add(this.simpleInput);
            this.groupBox1.Controls.Add(this.simpleComboBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(908, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // limpiarFiltroBtn
            // 
            this.limpiarFiltroBtn.Location = new System.Drawing.Point(679, 21);
            this.limpiarFiltroBtn.Name = "limpiarFiltroBtn";
            this.limpiarFiltroBtn.Size = new System.Drawing.Size(107, 23);
            this.limpiarFiltroBtn.TabIndex = 9;
            this.limpiarFiltroBtn.Text = "Limpiar Filtro";
            this.limpiarFiltroBtn.UseVisualStyleBackColor = true;
            this.limpiarFiltroBtn.Click += new System.EventHandler(this.limpiarFiltroBtn_Click);
            // 
            // simpleInput
            // 
            this.simpleInput.Location = new System.Drawing.Point(164, 21);
            this.simpleInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleInput.Name = "simpleInput";
            this.simpleInput.Size = new System.Drawing.Size(494, 23);
            this.simpleInput.TabIndex = 8;
            // 
            // simpleComboBox
            // 
            this.simpleComboBox.FormattingEnabled = true;
            this.simpleComboBox.Location = new System.Drawing.Point(12, 21);
            this.simpleComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleComboBox.Name = "simpleComboBox";
            this.simpleComboBox.Size = new System.Drawing.Size(133, 23);
            this.simpleComboBox.TabIndex = 6;
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
            this.panel1.Size = new System.Drawing.Size(908, 37);
            this.panel1.TabIndex = 1;
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(636, 6);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(150, 23);
            this.SalirButton.TabIndex = 3;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(428, 6);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(150, 23);
            this.EliminarButton.TabIndex = 2;
            this.EliminarButton.Text = "Eliminar Seleccion";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Location = new System.Drawing.Point(220, 6);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(150, 23);
            this.ModificarButton.TabIndex = 1;
            this.ModificarButton.Text = "Modificar Seleccion";
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // CrearButton
            // 
            this.CrearButton.Location = new System.Drawing.Point(12, 6);
            this.CrearButton.Name = "CrearButton";
            this.CrearButton.Size = new System.Drawing.Size(150, 23);
            this.CrearButton.TabIndex = 0;
            this.CrearButton.Text = "Crear Articulo";
            this.CrearButton.UseVisualStyleBackColor = true;
            this.CrearButton.Click += new System.EventHandler(this.CrearButton_Click);
            // 
            // ListadoGrid
            // 
            this.ListadoGrid.AllowUserToAddRows = false;
            this.ListadoGrid.AllowUserToDeleteRows = false;
            this.ListadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListadoGrid.Location = new System.Drawing.Point(0, 56);
            this.ListadoGrid.Name = "ListadoGrid";
            this.ListadoGrid.ReadOnly = true;
            this.ListadoGrid.RowTemplate.Height = 25;
            this.ListadoGrid.Size = new System.Drawing.Size(908, 357);
            this.ListadoGrid.TabIndex = 2;
            // 
            // ArticulosListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.ListadoGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ArticulosListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listado de Articulos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CrearButton;
        private System.Windows.Forms.DataGridView ListadoGrid;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.ComboBox simpleComboBox;
        private System.Windows.Forms.TextBox simpleInput;
        private System.Windows.Forms.Button limpiarFiltroBtn;
    }
}