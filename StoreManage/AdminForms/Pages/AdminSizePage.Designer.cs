namespace StoreManage.AdminForms.Pages
{
    partial class AdminSizePage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSizePage));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.rBDesc = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rBAsc = new Guna.UI2.WinForms.Guna2RadioButton();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // rBDesc
            // 
            this.rBDesc.AutoSize = true;
            this.rBDesc.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBDesc.CheckedState.BorderThickness = 0;
            this.rBDesc.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBDesc.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rBDesc.CheckedState.InnerOffset = -4;
            this.rBDesc.Location = new System.Drawing.Point(966, 110);
            this.rBDesc.Name = "rBDesc";
            this.rBDesc.Size = new System.Drawing.Size(65, 20);
            this.rBDesc.TabIndex = 50;
            this.rBDesc.Text = "DESC";
            this.rBDesc.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rBDesc.UncheckedState.BorderThickness = 2;
            this.rBDesc.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rBDesc.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rBDesc.UseVisualStyleBackColor = true;
            this.rBDesc.CheckedChanged += new System.EventHandler(this.SortOrderChanged);
            // 
            // rBAsc
            // 
            this.rBAsc.AutoSize = true;
            this.rBAsc.Checked = true;
            this.rBAsc.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBAsc.CheckedState.BorderThickness = 0;
            this.rBAsc.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rBAsc.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rBAsc.CheckedState.InnerOffset = -4;
            this.rBAsc.Location = new System.Drawing.Point(905, 110);
            this.rBAsc.Name = "rBAsc";
            this.rBAsc.Size = new System.Drawing.Size(55, 20);
            this.rBAsc.TabIndex = 49;
            this.rBAsc.TabStop = true;
            this.rBAsc.Text = "ASC";
            this.rBAsc.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rBAsc.UncheckedState.BorderThickness = 2;
            this.rBAsc.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rBAsc.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rBAsc.UseVisualStyleBackColor = true;
            this.rBAsc.CheckedChanged += new System.EventHandler(this.SortOrderChanged);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(23, 136);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1072, 610);
            this.flowLayoutPanel.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 38);
            this.label1.TabIndex = 47;
            this.label1.Text = "Size";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-13, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 2);
            this.panel1.TabIndex = 46;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.HoverState.ImageSize = new System.Drawing.Size(50, 46);
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAdd.Location = new System.Drawing.Point(31, 85);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PressedState.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(50, 46);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AdminSizePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rBDesc);
            this.Controls.Add(this.rBAsc);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdd);
            this.Name = "AdminSizePage";
            this.Size = new System.Drawing.Size(1137, 755);
            this.Load += new System.EventHandler(this.AdminSizePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2RadioButton rBDesc;
        private Guna.UI2.WinForms.Guna2RadioButton rBAsc;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton btnAdd;
    }
}
