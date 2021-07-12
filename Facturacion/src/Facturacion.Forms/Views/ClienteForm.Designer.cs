
namespace Facturacion.Forms.Views
{
    partial class ClienteForm
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
            this.NombreBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CedulaBox = new System.Windows.Forms.TextBox();
            this.ActivoBox = new System.Windows.Forms.CheckBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo/Razon Social:";
            // 
            // NombreBox
            // 
            this.NombreBox.Location = new System.Drawing.Point(199, 12);
            this.NombreBox.Name = "NombreBox";
            this.NombreBox.Size = new System.Drawing.Size(308, 23);
            this.NombreBox.TabIndex = 1;
            this.NombreBox.TextChanged += new System.EventHandler(this.NombreBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cedula/RNC:";
            // 
            // CedulaBox
            // 
            this.CedulaBox.Location = new System.Drawing.Point(199, 41);
            this.CedulaBox.MaxLength = 16;
            this.CedulaBox.Name = "CedulaBox";
            this.CedulaBox.Size = new System.Drawing.Size(308, 23);
            this.CedulaBox.TabIndex = 3;
            this.CedulaBox.TextChanged += new System.EventHandler(this.CedulaBox_TextChanged);
            // 
            // ActivoBox
            // 
            this.ActivoBox.AutoSize = true;
            this.ActivoBox.Location = new System.Drawing.Point(199, 71);
            this.ActivoBox.Name = "ActivoBox";
            this.ActivoBox.Size = new System.Drawing.Size(60, 19);
            this.ActivoBox.TabIndex = 4;
            this.ActivoBox.Text = "Activo";
            this.ActivoBox.UseVisualStyleBackColor = true;
            this.ActivoBox.CheckedChanged += new System.EventHandler(this.ActivoBox_CheckedChanged);
            // 
            // GuardarButton
            // 
            this.GuardarButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.GuardarButton.Location = new System.Drawing.Point(292, 92);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(105, 23);
            this.GuardarButton.TabIndex = 5;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Location = new System.Drawing.Point(403, 92);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(104, 23);
            this.CancelarButton.TabIndex = 6;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // ClienteForm
            // 
            this.AcceptButton = this.GuardarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarButton;
            this.ClientSize = new System.Drawing.Size(519, 127);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.ActivoBox);
            this.Controls.Add(this.CedulaBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClienteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear/Modificar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CedulaBox;
        private System.Windows.Forms.CheckBox ActivoBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button CancelarButton;
    }
}