
namespace Facturacion.Forms.Views
{
    partial class LoginForm
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
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(12, 12);
            this.UsernameBox.MaxLength = 20;
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.PlaceholderText = "Nombre de Usuario";
            this.UsernameBox.Size = new System.Drawing.Size(400, 23);
            this.UsernameBox.TabIndex = 1;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(12, 41);
            this.PasswordBox.MaxLength = 20;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.PlaceholderText = "Contrasena";
            this.PasswordBox.Size = new System.Drawing.Size(400, 23);
            this.PasswordBox.TabIndex = 3;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(206, 76);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(100, 23);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Iniciar Sesion";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(312, 76);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 23);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Cerrar Sistema";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(424, 111);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Iniciar Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button CloseButton;
    }
}