
namespace Facturacion.Forms.Views
{
    partial class VendedoresListForm
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
            this.agregarBtn = new System.Windows.Forms.Button();
            this.modificarBtn = new System.Windows.Forms.Button();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.cerrarBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // limiparBtn
            // 
            this.limiparBtn.Location = new System.Drawing.Point(607, 22);
            this.limiparBtn.Name = "limiparBtn";
            this.limiparBtn.Size = new System.Drawing.Size(90, 23);
            this.limiparBtn.TabIndex = 12;
            this.limiparBtn.Text = "Limpiar Filtro";
            this.limiparBtn.UseVisualStyleBackColor = true;
            this.limiparBtn.Click += new System.EventHandler(this.LimpiarFiltroButton_Click);
            // 
            // simpleComboBox
            // 
            this.simpleComboBox.FormattingEnabled = true;
            this.simpleComboBox.Location = new System.Drawing.Point(6, 21);
            this.simpleComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleComboBox.Name = "simpleComboBox";
            this.simpleComboBox.Size = new System.Drawing.Size(160, 23);
            this.simpleComboBox.TabIndex = 9;
            // 
            // simpleInput
            // 
            this.simpleInput.Location = new System.Drawing.Point(186, 21);
            this.simpleInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleInput.Name = "simpleInput";
            this.simpleInput.Size = new System.Drawing.Size(404, 23);
            this.simpleInput.TabIndex = 11;
            this.simpleInput.TextChanged += new System.EventHandler(this.OnTextChangedControls);
            // 
            // agregarBtn
            // 
            this.agregarBtn.Location = new System.Drawing.Point(12, 10);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(150, 23);
            this.agregarBtn.TabIndex = 0;
            this.agregarBtn.Text = "Agregar Vendedor";
            this.agregarBtn.UseVisualStyleBackColor = true;
            this.agregarBtn.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // modificarBtn
            // 
            this.modificarBtn.Location = new System.Drawing.Point(182, 10);
            this.modificarBtn.Name = "modificarBtn";
            this.modificarBtn.Size = new System.Drawing.Size(150, 23);
            this.modificarBtn.TabIndex = 1;
            this.modificarBtn.Text = "Modificar Seleccionado";
            this.modificarBtn.UseVisualStyleBackColor = true;
            this.modificarBtn.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Location = new System.Drawing.Point(352, 10);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(150, 23);
            this.eliminarBtn.TabIndex = 2;
            this.eliminarBtn.Text = "Eliminar Seleccionados";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            this.eliminarBtn.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // cerrarBtn
            // 
            this.cerrarBtn.Location = new System.Drawing.Point(522, 10);
            this.cerrarBtn.Name = "cerrarBtn";
            this.cerrarBtn.Size = new System.Drawing.Size(150, 23);
            this.cerrarBtn.TabIndex = 3;
            this.cerrarBtn.Text = "Cerrar";
            this.cerrarBtn.UseVisualStyleBackColor = true;
            this.cerrarBtn.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cerrarBtn);
            this.panel1.Controls.Add(this.eliminarBtn);
            this.panel1.Controls.Add(this.modificarBtn);
            this.panel1.Controls.Add(this.agregarBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 441);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 45);
            this.panel1.TabIndex = 1;
            // 
            // ListadoGrid
            // 
            this.ListadoGrid.AllowUserToAddRows = false;
            this.ListadoGrid.AllowUserToDeleteRows = false;
            this.ListadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListadoGrid.Location = new System.Drawing.Point(0, 58);
            this.ListadoGrid.Name = "ListadoGrid";
            this.ListadoGrid.ReadOnly = true;
            this.ListadoGrid.RowTemplate.Height = 25;
            this.ListadoGrid.Size = new System.Drawing.Size(790, 383);
            this.ListadoGrid.TabIndex = 2;
            // 
            // VendedoresListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 486);
            this.Controls.Add(this.ListadoGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "VendedoresListForm";
            this.Text = "Listado de Vendedores";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.Button modificarBtn;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button cerrarBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ListadoGrid;
        private System.Windows.Forms.Button limiparBtn;
        private System.Windows.Forms.ComboBox simpleComboBox;
        private System.Windows.Forms.TextBox simpleInput;
    }
}