namespace BCLoginRegistrationForm
{
    partial class RegistrationForm
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmailInvalid = new System.Windows.Forms.Label();
            this.chkShowHide = new System.Windows.Forms.CheckBox();
            this.lnklblSignOn = new System.Windows.Forms.LinkLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(236, 60);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(325, 26);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(236, 114);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(325, 26);
            this.txtLastName.TabIndex = 1;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(236, 169);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(325, 26);
            this.txtEmailAddress.TabIndex = 2;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(236, 220);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(325, 26);
            this.txtContact.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(236, 324);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(325, 33);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(236, 387);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(325, 33);
            this.txtConfirmPassword.TabIndex = 5;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(32, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 27);
            this.label10.TabIndex = 24;
            this.label10.Text = "Contact:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(33, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(690, 27);
            this.label9.TabIndex = 23;
            this.label9.Text = "__________________________________________________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(32, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 27);
            this.label5.TabIndex = 22;
            this.label5.Text = "Confirm Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(32, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 27);
            this.label4.TabIndex = 21;
            this.label4.Text = "Password: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(32, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 27);
            this.label3.TabIndex = 20;
            this.label3.Text = "Email Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(32, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 27);
            this.label2.TabIndex = 19;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(32, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 27);
            this.label1.TabIndex = 18;
            this.label1.Text = "First Name: ";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.Teal;
            this.lblPassword.Location = new System.Drawing.Point(579, 353);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(129, 20);
            this.lblPassword.TabIndex = 27;
            this.lblPassword.Text = "e.g P@ssword23";
            // 
            // lblEmailInvalid
            // 
            this.lblEmailInvalid.AutoSize = true;
            this.lblEmailInvalid.ForeColor = System.Drawing.Color.Teal;
            this.lblEmailInvalid.Location = new System.Drawing.Point(567, 175);
            this.lblEmailInvalid.Name = "lblEmailInvalid";
            this.lblEmailInvalid.Size = new System.Drawing.Size(159, 20);
            this.lblEmailInvalid.TabIndex = 26;
            this.lblEmailInvalid.Text = "e.g wese@gmail.com";
            // 
            // chkShowHide
            // 
            this.chkShowHide.AutoSize = true;
            this.chkShowHide.ForeColor = System.Drawing.Color.Teal;
            this.chkShowHide.Location = new System.Drawing.Point(583, 326);
            this.chkShowHide.Name = "chkShowHide";
            this.chkShowHide.Size = new System.Drawing.Size(148, 24);
            this.chkShowHide.TabIndex = 25;
            this.chkShowHide.Text = "Show Password";
            this.chkShowHide.UseVisualStyleBackColor = true;
            this.chkShowHide.CheckedChanged += new System.EventHandler(this.chkShowHide_CheckedChanged);
            // 
            // lnklblSignOn
            // 
            this.lnklblSignOn.AutoSize = true;
            this.lnklblSignOn.Location = new System.Drawing.Point(166, 542);
            this.lnklblSignOn.Name = "lnklblSignOn";
            this.lnklblSignOn.Size = new System.Drawing.Size(248, 20);
            this.lnklblSignOn.TabIndex = 30;
            this.lnklblSignOn.TabStop = true;
            this.lnklblSignOn.Text = "Already a user? click here to login.";
            this.lnklblSignOn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblSignOn_LinkClicked);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Teal;
            this.btnExit.Location = new System.Drawing.Point(452, 454);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 40);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Arial Narrow", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Teal;
            this.btnSubmit.Location = new System.Drawing.Point(247, 454);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(138, 40);
            this.btnSubmit.TabIndex = 28;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Teal;
            this.btnClear.Location = new System.Drawing.Point(38, 454);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(138, 40);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(903, 644);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lnklblSignOn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmailInvalid);
            this.Controls.Add(this.chkShowHide);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "RegistrationForm";
            this.Text = "Registration Done Here";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmailInvalid;
        private System.Windows.Forms.CheckBox chkShowHide;
        private System.Windows.Forms.LinkLabel lnklblSignOn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
    }
}