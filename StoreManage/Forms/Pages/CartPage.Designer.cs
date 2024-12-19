namespace StoreManage.Forms.Pages
{
    partial class CartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartPage));
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotalOrder = new System.Windows.Forms.Label();
            this.lbTransportFee = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.lbTotalMoney = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pBMomo = new System.Windows.Forms.PictureBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.pBVNPay = new System.Windows.Forms.PictureBox();
            this.bpMasterCard = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pBVisa = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pBZalo = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBMomo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBVNPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpMasterCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBVisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBZalo)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giỏ hàng";
            // 
            // lbTotalOrder
            // 
            this.lbTotalOrder.AutoSize = true;
            this.lbTotalOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalOrder.ForeColor = System.Drawing.Color.Black;
            this.lbTotalOrder.Location = new System.Drawing.Point(261, 220);
            this.lbTotalOrder.Name = "lbTotalOrder";
            this.lbTotalOrder.Size = new System.Drawing.Size(121, 19);
            this.lbTotalOrder.TabIndex = 36;
            this.lbTotalOrder.Text = "$Tổng thanh toán";
            // 
            // lbTransportFee
            // 
            this.lbTransportFee.AutoSize = true;
            this.lbTransportFee.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransportFee.ForeColor = System.Drawing.Color.Black;
            this.lbTransportFee.Location = new System.Drawing.Point(261, 159);
            this.lbTransportFee.Name = "lbTransportFee";
            this.lbTransportFee.Size = new System.Drawing.Size(118, 25);
            this.lbTransportFee.TabIndex = 35;
            this.lbTransportFee.Text = "$Vận chuyển";
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.ForeColor = System.Drawing.Color.Black;
            this.lbDiscount.Location = new System.Drawing.Point(261, 124);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(101, 25);
            this.lbDiscount.TabIndex = 34;
            this.lbDiscount.Text = "%Discount";
            // 
            // lbTotalMoney
            // 
            this.lbTotalMoney.AutoSize = true;
            this.lbTotalMoney.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalMoney.ForeColor = System.Drawing.Color.Black;
            this.lbTotalMoney.Location = new System.Drawing.Point(261, 87);
            this.lbTotalMoney.Name = "lbTotalMoney";
            this.lbTotalMoney.Size = new System.Drawing.Size(103, 25);
            this.lbTotalMoney.TabIndex = 33;
            this.lbTotalMoney.Text = "$Tổng tiền";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lbTotalOrder);
            this.panel4.Controls.Add(this.lbTransportFee);
            this.panel4.Controls.Add(this.lbDiscount);
            this.panel4.Controls.Add(this.lbTotalMoney);
            this.panel4.Controls.Add(this.pBMomo);
            this.panel4.Controls.Add(this.btnOrder);
            this.panel4.Controls.Add(this.pBVNPay);
            this.panel4.Controls.Add(this.bpMasterCard);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.pBVisa);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.pBZalo);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(641, 91);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(412, 432);
            this.panel4.TabIndex = 6;
            // 
            // pBMomo
            // 
            this.pBMomo.Image = ((System.Drawing.Image)(resources.GetObject("pBMomo.Image")));
            this.pBMomo.Location = new System.Drawing.Point(346, 351);
            this.pBMomo.Name = "pBMomo";
            this.pBMomo.Size = new System.Drawing.Size(49, 31);
            this.pBMomo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBMomo.TabIndex = 32;
            this.pBMomo.TabStop = false;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(175)))), ((int)(((byte)(23)))));
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(24, 271);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(374, 52);
            this.btnOrder.TabIndex = 21;
            this.btnOrder.Text = "Mua hàng";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // pBVNPay
            // 
            this.pBVNPay.Image = ((System.Drawing.Image)(resources.GetObject("pBVNPay.Image")));
            this.pBVNPay.Location = new System.Drawing.Point(263, 351);
            this.pBVNPay.Name = "pBVNPay";
            this.pBVNPay.Size = new System.Drawing.Size(77, 31);
            this.pBVNPay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBVNPay.TabIndex = 31;
            this.pBVNPay.TabStop = false;
            // 
            // bpMasterCard
            // 
            this.bpMasterCard.Image = ((System.Drawing.Image)(resources.GetObject("bpMasterCard.Image")));
            this.bpMasterCard.Location = new System.Drawing.Point(180, 351);
            this.bpMasterCard.Name = "bpMasterCard";
            this.bpMasterCard.Size = new System.Drawing.Size(77, 31);
            this.bpMasterCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bpMasterCard.TabIndex = 30;
            this.bpMasterCard.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 19);
            this.label9.TabIndex = 5;
            this.label9.Text = "Tổng thanh toán";
            // 
            // pBVisa
            // 
            this.pBVisa.Image = ((System.Drawing.Image)(resources.GetObject("pBVisa.Image")));
            this.pBVisa.Location = new System.Drawing.Point(109, 351);
            this.pBVisa.Name = "pBVisa";
            this.pBVisa.Size = new System.Drawing.Size(65, 31);
            this.pBVisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBVisa.TabIndex = 29;
            this.pBVisa.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(24, 207);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(374, 1);
            this.panel6.TabIndex = 3;
            // 
            // pBZalo
            // 
            this.pBZalo.Image = ((System.Drawing.Image)(resources.GetObject("pBZalo.Image")));
            this.pBZalo.Location = new System.Drawing.Point(26, 351);
            this.pBZalo.Name = "pBZalo";
            this.pBZalo.Size = new System.Drawing.Size(77, 31);
            this.pBZalo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBZalo.TabIndex = 28;
            this.pBZalo.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(117)))));
            this.label8.Location = new System.Drawing.Point(25, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Vận chuyển";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(117)))));
            this.label7.Location = new System.Drawing.Point(25, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Mã giảm giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(117)))));
            this.label5.Location = new System.Drawing.Point(25, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tổng tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 35);
            this.label6.TabIndex = 2;
            this.label6.Text = "Chi tiết đơn hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sản phẩm nguyên giá";
            // 
            // flowLayout
            // 
            this.flowLayout.AutoScroll = true;
            this.flowLayout.BackColor = System.Drawing.Color.White;
            this.flowLayout.Location = new System.Drawing.Point(0, 254);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(610, 528);
            this.flowLayout.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(0, 178);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(610, 70);
            this.panel5.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(610, 70);
            this.panel3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(489, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chúc mừng! Đơn hàng của bạn được Miễn phí vận chuyển";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1070, 70);
            this.panel2.TabIndex = 4;
            // 
            // CartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.flowLayout);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "CartPage";
            this.Size = new System.Drawing.Size(1070, 798);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBMomo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBVNPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpMasterCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBVisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBZalo)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotalOrder;
        private System.Windows.Forms.Label lbTransportFee;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label lbTotalMoney;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pBMomo;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.PictureBox pBVNPay;
        private System.Windows.Forms.PictureBox bpMasterCard;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pBVisa;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pBZalo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayout;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
    }
}
