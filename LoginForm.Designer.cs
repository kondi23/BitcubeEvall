namespace BCLoginRegistrationForm
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.LnkLblCreateAccount = new System.Windows.Forms.LinkLabel();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.ChckShowPassword = new System.Windows.Forms.CheckBox();
            this.chckBoxRememberPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(25, 31);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(160, 32);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username: ";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(29, 94);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(154, 32);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password: ";
            // 
            // LnkLblCreateAccount
            // 
            this.LnkLblCreateAccount.AutoSize = true;
            this.LnkLblCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkLblCreateAccount.LinkColor = System.Drawing.Color.Purple;
            this.LnkLblCreateAccount.Location = new System.Drawing.Point(187, 269);
            this.LnkLblCreateAccount.Name = "LnkLblCreateAccount";
            this.LnkLblCreateAccount.Size = new System.Drawing.Size(288, 22);
            this.LnkLblCreateAccount.TabIndex = 6;
            this.LnkLblCreateAccount.TabStop = true;
            this.LnkLblCreateAccount.Text = " Click Here to Create New Account";
            this.LnkLblCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblCreateAccount_LinkClicked);
            // 
            // TxtUsername
            // 
            this.TxtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.Location = new System.Drawing.Point(191, 31);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(392, 39);
            this.TxtUsername.TabIndex = 1;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(191, 94);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(392, 39);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.UseSystemPasswordChar = true;
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(191, 190);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(171, 54);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "&Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(415, 190);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(168, 53);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // ChckShowPassword
            // 
            this.ChckShowPassword.AutoSize = true;
            this.ChckShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChckShowPassword.Location = new System.Drawing.Point(191, 143);
            this.ChckShowPassword.Name = "ChckShowPassword";
            this.ChckShowPassword.Size = new System.Drawing.Size(148, 24);
            this.ChckShowPassword.TabIndex = 3;
            this.ChckShowPassword.Text = "Show Password";
            this.ChckShowPassword.UseVisualStyleBackColor = true;
            this.ChckShowPassword.CheckedChanged += new System.EventHandler(this.ChckShowPassword_CheckedChanged);
            // 
            // chckBoxRememberPass
            // 
            this.chckBoxRememberPass.AutoSize = true;
            this.chckBoxRememberPass.Location = new System.Drawing.Point(370, 143);
            this.chckBoxRememberPass.Name = "chckBoxRememberPass";
            this.chckBoxRememberPass.Size = new System.Drawing.Size(192, 24);
            this.chckBoxRememberPass.TabIndex = 7;
            this.chckBoxRememberPass.Text = "Remember Username";
            this.chckBoxRememberPass.UseVisualStyleBackColor = true;
            this.chckBoxRememberPass.CheckedChanged += new System.EventHandler(this.chckBoxRememberPass_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(665, 332);
            this.Controls.Add(this.chckBoxRememberPass);
            this.Controls.Add(this.ChckShowPassword);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.LnkLblCreateAccount);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Name = "LoginForm";
            this.Text = "Login Here";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.LinkLabel LnkLblCreateAccount;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.CheckBox ChckShowPassword;
        private System.Windows.Forms.CheckBox chckBoxRememberPass;
    }
}