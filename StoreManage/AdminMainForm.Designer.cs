namespace StoreManage
{
    partial class AdminMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBAvatarEdit = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.controlboxMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.controlboxTurnOff = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnSubcategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnColor = new Guna.UI2.WinForms.Guna2Button();
            this.btnSize = new Guna.UI2.WinForms.Guna2Button();
            this.btnProvider = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrder = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBAvatarEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.btnProvider);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Controls.Add(this.btnSize);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.btnSubcategory);
            this.panel1.Controls.Add(this.btnCategory);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.pBAvatarEdit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 803);
            this.panel1.TabIndex = 0;
            // 
            // pBAvatarEdit
            // 
            this.pBAvatarEdit.AllowFocused = false;
            this.pBAvatarEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pBAvatarEdit.AutoSizeHeight = true;
            this.pBAvatarEdit.BorderRadius = 63;
            this.pBAvatarEdit.Image = ((System.Drawing.Image)(resources.GetObject("pBAvatarEdit.Image")));
            this.pBAvatarEdit.IsCircle = true;
            this.pBAvatarEdit.Location = new System.Drawing.Point(48, 27);
            this.pBAvatarEdit.Name = "pBAvatarEdit";
            this.pBAvatarEdit.Size = new System.Drawing.Size(127, 127);
            this.pBAvatarEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBAvatarEdit.TabIndex = 13;
            this.pBAvatarEdit.TabStop = false;
            this.pBAvatarEdit.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // btnHome
            // 
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Location = new System.Drawing.Point(13, 211);
            this.btnHome.Name = "btnHome";
            this.btnHome.PressedColor = System.Drawing.Color.Navy;
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(161, 45);
            this.btnHome.TabIndex = 14;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // controlboxMinimize
            // 
            this.controlboxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlboxMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.controlboxMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(133)))));
            this.controlboxMinimize.HoverState.Parent = this.controlboxMinimize;
            this.controlboxMinimize.IconColor = System.Drawing.Color.White;
            this.controlboxMinimize.Location = new System.Drawing.Point(1265, 12);
            this.controlboxMinimize.Name = "controlboxMinimize";
            this.controlboxMinimize.ShadowDecoration.Parent = this.controlboxMinimize;
            this.controlboxMinimize.Size = new System.Drawing.Size(32, 27);
            this.controlboxMinimize.TabIndex = 13;
            // 
            // controlboxTurnOff
            // 
            this.controlboxTurnOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlboxTurnOff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(133)))));
            this.controlboxTurnOff.HoverState.FillColor = System.Drawing.Color.Red;
            this.controlboxTurnOff.HoverState.Parent = this.controlboxTurnOff;
            this.controlboxTurnOff.IconColor = System.Drawing.Color.White;
            this.controlboxTurnOff.Location = new System.Drawing.Point(1303, 12);
            this.controlboxTurnOff.Name = "controlboxTurnOff";
            this.controlboxTurnOff.ShadowDecoration.Parent = this.controlboxTurnOff;
            this.controlboxTurnOff.Size = new System.Drawing.Size(32, 27);
            this.controlboxTurnOff.TabIndex = 12;
            // 
            // btnCategory
            // 
            this.btnCategory.CheckedState.Parent = this.btnCategory;
            this.btnCategory.CustomImages.Parent = this.btnCategory;
            this.btnCategory.FillColor = System.Drawing.Color.Transparent;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.HoverState.Parent = this.btnCategory;
            this.btnCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnCategory.Image")));
            this.btnCategory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCategory.Location = new System.Drawing.Point(13, 273);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.PressedColor = System.Drawing.Color.Navy;
            this.btnCategory.ShadowDecoration.Parent = this.btnCategory;
            this.btnCategory.Size = new System.Drawing.Size(181, 45);
            this.btnCategory.TabIndex = 15;
            this.btnCategory.Text = "Category";
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.CheckedState.Parent = this.btnProduct;
            this.btnProduct.CustomImages.Parent = this.btnProduct;
            this.btnProduct.FillColor = System.Drawing.Color.Transparent;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.HoverState.Parent = this.btnProduct;
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProduct.Location = new System.Drawing.Point(13, 397);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.PressedColor = System.Drawing.Color.Navy;
            this.btnProduct.ShadowDecoration.Parent = this.btnProduct;
            this.btnProduct.Size = new System.Drawing.Size(181, 45);
            this.btnProduct.TabIndex = 17;
            this.btnProduct.Text = "Product";
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnSubcategory
            // 
            this.btnSubcategory.CheckedState.Parent = this.btnSubcategory;
            this.btnSubcategory.CustomImages.Parent = this.btnSubcategory;
            this.btnSubcategory.FillColor = System.Drawing.Color.Transparent;
            this.btnSubcategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubcategory.ForeColor = System.Drawing.Color.White;
            this.btnSubcategory.HoverState.Parent = this.btnSubcategory;
            this.btnSubcategory.Image = ((System.Drawing.Image)(resources.GetObject("btnSubcategory.Image")));
            this.btnSubcategory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSubcategory.Location = new System.Drawing.Point(13, 335);
            this.btnSubcategory.Name = "btnSubcategory";
            this.btnSubcategory.PressedColor = System.Drawing.Color.Navy;
            this.btnSubcategory.ShadowDecoration.Parent = this.btnSubcategory;
            this.btnSubcategory.Size = new System.Drawing.Size(191, 45);
            this.btnSubcategory.TabIndex = 16;
            this.btnSubcategory.Text = "SubCategory";
            this.btnSubcategory.Click += new System.EventHandler(this.btnSubcategory_Click);
            // 
            // btnColor
            // 
            this.btnColor.CheckedState.Parent = this.btnColor;
            this.btnColor.CustomImages.Parent = this.btnColor;
            this.btnColor.FillColor = System.Drawing.Color.Transparent;
            this.btnColor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.ForeColor = System.Drawing.Color.White;
            this.btnColor.HoverState.Parent = this.btnColor;
            this.btnColor.Image = ((System.Drawing.Image)(resources.GetObject("btnColor.Image")));
            this.btnColor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnColor.Location = new System.Drawing.Point(13, 521);
            this.btnColor.Name = "btnColor";
            this.btnColor.PressedColor = System.Drawing.Color.Navy;
            this.btnColor.ShadowDecoration.Parent = this.btnColor;
            this.btnColor.Size = new System.Drawing.Size(181, 45);
            this.btnColor.TabIndex = 19;
            this.btnColor.Text = "Color";
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnSize
            // 
            this.btnSize.CheckedState.Parent = this.btnSize;
            this.btnSize.CustomImages.Parent = this.btnSize;
            this.btnSize.FillColor = System.Drawing.Color.Transparent;
            this.btnSize.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSize.ForeColor = System.Drawing.Color.White;
            this.btnSize.HoverState.Parent = this.btnSize;
            this.btnSize.Image = ((System.Drawing.Image)(resources.GetObject("btnSize.Image")));
            this.btnSize.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSize.Location = new System.Drawing.Point(13, 459);
            this.btnSize.Name = "btnSize";
            this.btnSize.PressedColor = System.Drawing.Color.Navy;
            this.btnSize.ShadowDecoration.Parent = this.btnSize;
            this.btnSize.Size = new System.Drawing.Size(180, 45);
            this.btnSize.TabIndex = 18;
            this.btnSize.Text = "Size";
            this.btnSize.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // btnProvider
            // 
            this.btnProvider.CheckedState.Parent = this.btnProvider;
            this.btnProvider.CustomImages.Parent = this.btnProvider;
            this.btnProvider.FillColor = System.Drawing.Color.Transparent;
            this.btnProvider.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProvider.ForeColor = System.Drawing.Color.White;
            this.btnProvider.HoverState.Parent = this.btnProvider;
            this.btnProvider.Image = ((System.Drawing.Image)(resources.GetObject("btnProvider.Image")));
            this.btnProvider.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProvider.Location = new System.Drawing.Point(13, 645);
            this.btnProvider.Name = "btnProvider";
            this.btnProvider.PressedColor = System.Drawing.Color.Navy;
            this.btnProvider.ShadowDecoration.Parent = this.btnProvider;
            this.btnProvider.Size = new System.Drawing.Size(181, 45);
            this.btnProvider.TabIndex = 21;
            this.btnProvider.Text = "Provider";
            this.btnProvider.Click += new System.EventHandler(this.btnProvider_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.CheckedState.Parent = this.btnCustomer;
            this.btnCustomer.CustomImages.Parent = this.btnCustomer;
            this.btnCustomer.FillColor = System.Drawing.Color.Transparent;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.HoverState.Parent = this.btnCustomer;
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomer.Location = new System.Drawing.Point(13, 583);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.PressedColor = System.Drawing.Color.Navy;
            this.btnCustomer.ShadowDecoration.Parent = this.btnCustomer;
            this.btnCustomer.Size = new System.Drawing.Size(181, 45);
            this.btnCustomer.TabIndex = 20;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.CheckedState.Parent = this.btnOrder;
            this.btnOrder.CustomImages.Parent = this.btnOrder;
            this.btnOrder.FillColor = System.Drawing.Color.Transparent;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.HoverState.Parent = this.btnOrder;
            this.btnOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnOrder.Image")));
            this.btnOrder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOrder.Location = new System.Drawing.Point(13, 707);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.PressedColor = System.Drawing.Color.Navy;
            this.btnOrder.ShadowDecoration.Parent = this.btnOrder;
            this.btnOrder.Size = new System.Drawing.Size(191, 45);
            this.btnOrder.TabIndex = 22;
            this.btnOrder.Text = "Order";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.label1.Location = new System.Drawing.Point(18, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Administration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel.Location = new System.Drawing.Point(228, 48);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1129, 755);
            this.flowLayoutPanel.TabIndex = 14;
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1347, 798);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.controlboxMinimize);
            this.Controls.Add(this.controlboxTurnOff);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBAvatarEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Bunifu.UI.WinForms.BunifuPictureBox pBAvatarEdit;
        private Guna.UI2.WinForms.Guna2ControlBox controlboxMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox controlboxTurnOff;
        private Guna.UI2.WinForms.Guna2Button btnCategory;
        private Guna.UI2.WinForms.Guna2Button btnProvider;
        private Guna.UI2.WinForms.Guna2Button btnCustomer;
        private Guna.UI2.WinForms.Guna2Button btnColor;
        private Guna.UI2.WinForms.Guna2Button btnSize;
        private Guna.UI2.WinForms.Guna2Button btnProduct;
        private Guna.UI2.WinForms.Guna2Button btnSubcategory;
        private Guna.UI2.WinForms.Guna2Button btnOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}