namespace BCLoginRegistrationForm
{
    partial class BCMainForm
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
            this.components = new System.ComponentModel.Container();
            this.lblMain = new System.Windows.Forms.Label();
            this.lnklblLogOut = new System.Windows.Forms.LinkLabel();
            this.lnklblFriends = new System.Windows.Forms.LinkLabel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnChangePassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblMain.Font = new System.Drawing.Font("Papyrus", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.Red;
            this.lblMain.Location = new System.Drawing.Point(25, 50);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(670, 56);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "WELCOME TO PROFILE PAGE!!!";
            this.lblMain.Click += new System.EventHandler(this.lblMain_Click);
            // 
            // lnklblLogOut
            // 
            this.lnklblLogOut.AutoSize = true;
            this.lnklblLogOut.Location = new System.Drawing.Point(633, 118);
            this.lnklblLogOut.Name = "lnklblLogOut";
            this.lnklblLogOut.Size = new System.Drawing.Size(62, 20);
            this.lnklblLogOut.TabIndex = 1;
            this.lnklblLogOut.TabStop = true;
            this.lnklblLogOut.Text = "LogOut";
            this.lnklblLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblLogOut_LinkClicked);
            // 
            // lnklblFriends
            // 
            this.lnklblFriends.AutoSize = true;
            this.lnklblFriends.Location = new System.Drawing.Point(498, 118);
            this.lnklblFriends.Name = "lnklblFriends";
            this.lnklblFriends.Size = new System.Drawing.Size(103, 20);
            this.lnklblFriends.TabIndex = 3;
            this.lnklblFriends.TabStop = true;
            this.lnklblFriends.Text = "Friends Page";
            this.lnklblFriends.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblFriends_LinkClicked);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(178, 182);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(142, 32);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit Profile";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(172, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Edit Your Profile Details";
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Location = new System.Drawing.Point(211, 267);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(128, 20);
            this.lblUserInfo.TabIndex = 13;
            this.lblUserInfo.Text = "User Information";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(528, 155);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(167, 32);
            this.btnChangePassword.TabIndex = 14;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click_1);
            // 
            // BCMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(713, 489);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.lblUserInfo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lnklblFriends);
            this.Controls.Add(this.lnklblLogOut);
            this.Controls.Add(this.lblMain);
            this.Name = "BCMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.BCMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.LinkLabel lnklblLogOut;
        private System.Windows.Forms.LinkLabel lnklblFriends;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnChangePassword;
    }
}