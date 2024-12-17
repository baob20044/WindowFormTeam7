namespace StoreManage.Components
{
    partial class ShopItem
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
            this.lbPrice = new System.Windows.Forms.Label();
            this.pBImage = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(67)))), ((int)(((byte)(55)))));
            this.lbPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbPrice.Location = new System.Drawing.Point(114, 235);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(85, 35);
            this.lbPrice.TabIndex = 18;
            this.lbPrice.Text = "$Price";
            // 
            // pBImage
            // 
            this.pBImage.BackColor = System.Drawing.Color.Gainsboro;
            this.pBImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBImage.Location = new System.Drawing.Point(58, 19);
            this.pBImage.Name = "pBImage";
            this.pBImage.Size = new System.Drawing.Size(197, 162);
            this.pBImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBImage.TabIndex = 17;
            this.pBImage.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.lbName.Location = new System.Drawing.Point(12, 186);
            this.lbName.MaximumSize = new System.Drawing.Size(300, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(143, 28);
            this.lbName.TabIndex = 16;
            this.lbName.Text = "Product Name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShopItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pBImage);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbPrice);
            this.Name = "ShopItem";
            this.Size = new System.Drawing.Size(312, 270);
            ((System.ComponentModel.ISupportInitialize)(this.pBImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.PictureBox pBImage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbName;
    }
}
