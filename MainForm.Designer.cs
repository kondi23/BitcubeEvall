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
            this.lblMain = new System.Windows.Forms.Label();
            this.lnklblLogOut = new System.Windows.Forms.LinkLabel();
            this.lnklblProfile = new System.Windows.Forms.LinkLabel();
            this.lnklblFriends = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblMain.Font = new System.Drawing.Font("Papyrus", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.Red;
            this.lblMain.Location = new System.Drawing.Point(25, 50);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(579, 56);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "WELCOME TO THE SITE!!!";
            this.lblMain.Click += new System.EventHandler(this.lblMain_Click);
            // 
            // lnklblLogOut
            // 
            this.lnklblLogOut.AutoSize = true;
            this.lnklblLogOut.Location = new System.Drawing.Point(663, 50);
            this.lnklblLogOut.Name = "lnklblLogOut";
            this.lnklblLogOut.Size = new System.Drawing.Size(62, 20);
            this.lnklblLogOut.TabIndex = 1;
            this.lnklblLogOut.TabStop = true;
            this.lnklblLogOut.Text = "LogOut";
            this.lnklblLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblLogOut_LinkClicked);
            // 
            // lnklblProfile
            // 
            this.lnklblProfile.AutoSize = true;
            this.lnklblProfile.Location = new System.Drawing.Point(313, 254);
            this.lnklblProfile.Name = "lnklblProfile";
            this.lnklblProfile.Size = new System.Drawing.Size(132, 20);
            this.lnklblProfile.TabIndex = 2;
            this.lnklblProfile.TabStop = true;
            this.lnklblProfile.Text = "Check Out Profile";
            this.lnklblProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblProfile_LinkClicked);
            // 
            // lnklblFriends
            // 
            this.lnklblFriends.AutoSize = true;
            this.lnklblFriends.Location = new System.Drawing.Point(123, 253);
            this.lnklblFriends.Name = "lnklblFriends";
            this.lnklblFriends.Size = new System.Drawing.Size(147, 20);
            this.lnklblFriends.TabIndex = 3;
            this.lnklblFriends.TabStop = true;
            this.lnklblFriends.Text = "Go to Friends Page";
            this.lnklblFriends.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblFriends_LinkClicked);
            // 
            // BCMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lnklblFriends);
            this.Controls.Add(this.lnklblProfile);
            this.Controls.Add(this.lnklblLogOut);
            this.Controls.Add(this.lblMain);
            this.Name = "BCMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.BCMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.LinkLabel lnklblLogOut;
        private System.Windows.Forms.LinkLabel lnklblProfile;
        private System.Windows.Forms.LinkLabel lnklblFriends;
    }
}