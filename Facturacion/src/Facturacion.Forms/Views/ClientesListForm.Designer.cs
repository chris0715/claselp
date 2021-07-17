
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
            this.limiparBtn = new System.Windows.Forms.Button();
            this.simpleComboBox = new System.Windows.Forms.ComboBox();
            this.simpleInput = new System.Windows.Forms.TextBox();
            this.simpleBtnSearch = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.limiparBtn);
            this.groupBox1.Controls.Add(this.simpleComboBox);
            this.groupBox1.Controls.Add(this.simpleInput);
            this.groupBox1.Controls.Add(this.simpleBtnSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1138, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // limiparBtn
            // 
            this.limiparBtn.Location = new System.Drawing.Point(695, 17);
            this.limiparBtn.Name = "limiparBtn";
            this.limiparBtn.Size = new System.Drawing.Size(90, 23);
            this.limiparBtn.TabIndex = 8;
            this.limiparBtn.Text = "Limpiar Filtro";
            this.limiparBtn.UseVisualStyleBackColor = true;
            this.limiparBtn.Click += new System.EventHandler(this.LimpiarFiltroButton_Click);
            // 
            // simpleComboBox
            // 
            this.simpleComboBox.FormattingEnabled = true;
            this.simpleComboBox.Location = new System.Drawing.Point(6, 17);
            this.simpleComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleComboBox.Name = "simpleComboBox";
            this.simpleComboBox.Size = new System.Drawing.Size(160, 23);
            this.simpleComboBox.TabIndex = 5;
            this.simpleComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // simpleInput
            // 
            this.simpleInput.Location = new System.Drawing.Point(186, 17);
            this.simpleInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleInput.Name = "simpleInput";
            this.simpleInput.Size = new System.Drawing.Size(404, 23);
            this.simpleInput.TabIndex = 7;
            // 
            // simpleBtnSearch
            // 
            this.simpleBtnSearch.Location = new System.Drawing.Point(596, 18);
            this.simpleBtnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleBtnSearch.Name = "simpleBtnSearch";
            this.simpleBtnSearch.Size = new System.Drawing.Size(82, 22);
            this.simpleBtnSearch.TabIndex = 6;
            this.simpleBtnSearch.Text = "buscar";
            this.simpleBtnSearch.UseVisualStyleBackColor = true;
            this.simpleBtnSearch.Click += new System.EventHandler(this.buscarBtn_Click);
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
            this.panel1.Size = new System.Drawing.Size(1138, 50);
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
            this.ListadoGrid.RowHeadersWidth = 51;
            this.ListadoGrid.RowTemplate.Height = 25;
            this.ListadoGrid.Size = new System.Drawing.Size(1138, 363);
            this.ListadoGrid.TabIndex = 2;
            // 
            // ClientesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 461);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ListadoGrid;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button simpleBtnSearch;
        private System.Windows.Forms.ComboBox simpleComboBox;
        private System.Windows.Forms.TextBox simpleInput;
        private System.Windows.Forms.Button limiparBtn;
    }
}