
namespace Facturacion.Forms.Views
{
    partial class UsuarioForm
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
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FullNameBox = new System.Windows.Forms.TextBox();
            this.ActiveBox = new System.Windows.Forms.CheckBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.AbortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Usuario:";
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(131, 12);
            this.UsernameBox.MaxLength = 20;
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(391, 23);
            this.UsernameBox.TabIndex = 1;
            this.UsernameBox.TextChanged += new System.EventHandler(this.UsernameBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contrasena:";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(131, 41);
            this.PasswordBox.MaxLength = 20;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(391, 23);
            this.PasswordBox.TabIndex = 3;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre Completo:";
            // 
            // FullNameBox
            // 
            this.FullNameBox.Location = new System.Drawing.Point(131, 70);
            this.FullNameBox.MaxLength = 256;
            this.FullNameBox.Name = "FullNameBox";
            this.FullNameBox.Size = new System.Drawing.Size(391, 23);
            this.FullNameBox.TabIndex = 5;
            this.FullNameBox.TextChanged += new System.EventHandler(this.FullNameBox_TextChanged);
            // 
            // ActiveBox
            // 
            this.ActiveBox.AutoSize = true;
            this.ActiveBox.Location = new System.Drawing.Point(131, 99);
            this.ActiveBox.Name = "ActiveBox";
            this.ActiveBox.Size = new System.Drawing.Size(60, 19);
            this.ActiveBox.TabIndex = 6;
            this.ActiveBox.Text = "Activo";
            this.ActiveBox.UseVisualStyleBackColor = true;
            this.ActiveBox.CheckedChanged += new System.EventHandler(this.ActiveBox_CheckedChanged);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(332, 108);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(92, 23);
            this.CreateButton.TabIndex = 7;
            this.CreateButton.Text = "Crear";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // AbortButton
            // 
            this.AbortButton.Location = new System.Drawing.Point(430, 108);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(92, 23);
            this.AbortButton.TabIndex = 8;
            this.AbortButton.Text = "Cancelar";
            this.AbortButton.UseVisualStyleBackColor = true;
            // 
            // UsuarioForm
            // 
            this.AcceptButton = this.CreateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.AbortButton;
            this.ClientSize = new System.Drawing.Size(534, 143);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.ActiveBox);
            this.Controls.Add(this.FullNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsuarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear/Modificar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FullNameBox;
        private System.Windows.Forms.CheckBox ActiveBox;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button AbortButton;
    }
}