
namespace Facturacion.Forms.Views
{
    partial class ArticuloForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CostBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StockBox = new System.Windows.Forms.TextBox();
            this.ActivoBox = new System.Windows.Forms.CheckBox();
            this.Accept_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion:";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(105, 12);
            this.DescriptionBox.MaxLength = 256;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(269, 23);
            this.DescriptionBox.TabIndex = 1;
            this.DescriptionBox.TextChanged += new System.EventHandler(this.DescriptionBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Costo Unitario:";
            // 
            // CostBox
            // 
            this.CostBox.Location = new System.Drawing.Point(105, 41);
            this.CostBox.Name = "CostBox";
            this.CostBox.Size = new System.Drawing.Size(269, 23);
            this.CostBox.TabIndex = 3;
            this.CostBox.TextChanged += new System.EventHandler(this.CostBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio Unitario:";
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(105, 70);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(269, 23);
            this.PriceBox.TabIndex = 5;
            this.PriceBox.TextChanged += new System.EventHandler(this.PriceBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Unidades Disponibles:";
            // 
            // StockBox
            // 
            this.StockBox.Location = new System.Drawing.Point(141, 99);
            this.StockBox.Name = "StockBox";
            this.StockBox.Size = new System.Drawing.Size(100, 23);
            this.StockBox.TabIndex = 7;
            this.StockBox.TextChanged += new System.EventHandler(this.StockBox_TextChanged);
            // 
            // ActivoBox
            // 
            this.ActivoBox.AutoSize = true;
            this.ActivoBox.Location = new System.Drawing.Point(141, 129);
            this.ActivoBox.Name = "ActivoBox";
            this.ActivoBox.Size = new System.Drawing.Size(60, 19);
            this.ActivoBox.TabIndex = 8;
            this.ActivoBox.Text = "Activo";
            this.ActivoBox.UseVisualStyleBackColor = true;
            this.ActivoBox.CheckedChanged += new System.EventHandler(this.ActivoBox_CheckedChanged);
            // 
            // Accept_Button
            // 
            this.Accept_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Accept_Button.Location = new System.Drawing.Point(12, 153);
            this.Accept_Button.Name = "Accept_Button";
            this.Accept_Button.Size = new System.Drawing.Size(173, 23);
            this.Accept_Button.TabIndex = 9;
            this.Accept_Button.Text = "Guardar";
            this.Accept_Button.UseVisualStyleBackColor = true;
            this.Accept_Button.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(201, 153);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(173, 23);
            this.Cancel_Button.TabIndex = 10;
            this.Cancel_Button.Text = "Cancelar";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // ArticuloForm
            // 
            this.AcceptButton = this.Accept_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(386, 188);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Accept_Button);
            this.Controls.Add(this.ActivoBox);
            this.Controls.Add(this.StockBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CostBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArticuloForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear/Modificar Articulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CostBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StockBox;
        private System.Windows.Forms.CheckBox ActivoBox;
        private System.Windows.Forms.Button Accept_Button;
        private System.Windows.Forms.Button Cancel_Button;
    }
}