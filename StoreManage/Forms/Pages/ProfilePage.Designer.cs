namespace StoreManage.Forms.Pages
{
    partial class ProfilePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilePage));
            this.panel12 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPassword = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditProfile = new Guna.UI2.WinForms.Guna2Button();
            this.panel12.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.Controls.Add(this.label29);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1070, 87);
            this.panel12.TabIndex = 3;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(43, 23);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(125, 32);
            this.label29.TabIndex = 10;
            this.label29.Text = "My Profile";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 711);
            this.panel1.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(242, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(828, 711);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.btnPassword);
            this.guna2Panel1.Controls.Add(this.btnEditProfile);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(242, 711);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnPassword
            // 
            this.btnPassword.BorderColor = System.Drawing.Color.Gray;
            this.btnPassword.CheckedState.Parent = this.btnPassword;
            this.btnPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPassword.CustomBorderColor = System.Drawing.Color.Gray;
            this.btnPassword.CustomBorderThickness = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.btnPassword.CustomImages.Parent = this.btnPassword;
            this.btnPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPassword.FillColor = System.Drawing.Color.White;
            this.btnPassword.Font = new System.Drawing.Font("Segoe UI", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassword.ForeColor = System.Drawing.Color.Silver;
            this.btnPassword.HoverState.Parent = this.btnPassword;
            this.btnPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnPassword.Image")));
            this.btnPassword.Location = new System.Drawing.Point(0, 62);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.ShadowDecoration.Parent = this.btnPassword;
            this.btnPassword.Size = new System.Drawing.Size(242, 62);
            this.btnPassword.TabIndex = 1;
            this.btnPassword.Text = "Password";
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BorderColor = System.Drawing.Color.Gray;
            this.btnEditProfile.BorderThickness = 1;
            this.btnEditProfile.CheckedState.Parent = this.btnEditProfile;
            this.btnEditProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProfile.CustomImages.Parent = this.btnEditProfile;
            this.btnEditProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditProfile.FillColor = System.Drawing.Color.White;
            this.btnEditProfile.Font = new System.Drawing.Font("Segoe UI", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.ForeColor = System.Drawing.Color.Silver;
            this.btnEditProfile.HoverState.Parent = this.btnEditProfile;
            this.btnEditProfile.Image = global::StoreManage.Properties.Resources.Edit1;
            this.btnEditProfile.Location = new System.Drawing.Point(0, 0);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.ShadowDecoration.Parent = this.btnEditProfile;
            this.btnEditProfile.Size = new System.Drawing.Size(242, 62);
            this.btnEditProfile.TabIndex = 0;
            this.btnEditProfile.Text = "Edit Profile ";
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // ProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel12);
            this.Name = "ProfilePage";
            this.Size = new System.Drawing.Size(1070, 798);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnEditProfile;
        private Guna.UI2.WinForms.Guna2Button btnPassword;
    }
}
