
namespace PHP_SRePS
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
            this.lblRequires = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRequires
            // 
            this.lblRequires.AutoSize = true;
            this.lblRequires.Location = new System.Drawing.Point(13, 13);
            this.lblRequires.Name = "lblRequires";
            this.lblRequires.Size = new System.Drawing.Size(52, 15);
            this.lblRequires.TabIndex = 0;
            this.lblRequires.Text = "Requires";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(39, 28);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(131, 26);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Administrator";
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(13, 62);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PlaceholderText = "Password";
            this.txbPassword.Size = new System.Drawing.Size(291, 23);
            this.txbPassword.TabIndex = 2;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(81, 104);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(162, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Authorise Changes";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLoginForm_Click);
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.ForeColor = System.Drawing.Color.Red;
            this.lblIncorrect.Location = new System.Drawing.Point(197, 44);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(107, 15);
            this.lblIncorrect.TabIndex = 4;
            this.lblIncorrect.Text = "Incorrect password";
            this.lblIncorrect.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 139);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblRequires);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequires;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblIncorrect;
    }
}