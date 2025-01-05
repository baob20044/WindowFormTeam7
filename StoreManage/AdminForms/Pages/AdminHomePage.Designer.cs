namespace StoreManage.AdminForms.Pages
{
    partial class AdminHomePage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTotalAmount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.chartProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalAmount)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartProducts
            // 
            this.chartProducts.BorderlineColor = System.Drawing.Color.Black;
            this.chartProducts.BorderlineWidth = 3;
            chartArea3.Name = "ChartArea1";
            this.chartProducts.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartProducts.Legends.Add(legend3);
            this.chartProducts.Location = new System.Drawing.Point(3, 3);
            this.chartProducts.Name = "chartProducts";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartProducts.Series.Add(series3);
            this.chartProducts.Size = new System.Drawing.Size(1054, 742);
            this.chartProducts.TabIndex = 0;
            this.chartProducts.Text = "chart1";
            // 
            // chartTotalAmount
            // 
            this.chartTotalAmount.BorderlineColor = System.Drawing.Color.Black;
            this.chartTotalAmount.BorderlineWidth = 3;
            chartArea4.Name = "ChartArea1";
            this.chartTotalAmount.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartTotalAmount.Legends.Add(legend4);
            this.chartTotalAmount.Location = new System.Drawing.Point(3, 751);
            this.chartTotalAmount.Name = "chartTotalAmount";
            this.chartTotalAmount.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartTotalAmount.Series.Add(series4);
            this.chartTotalAmount.Size = new System.Drawing.Size(1054, 768);
            this.chartTotalAmount.TabIndex = 1;
            this.chartTotalAmount.Text = "chartTotalAmount";
            // 
            // btnPrint
            // 
            this.btnPrint.CheckedState.Parent = this.btnPrint;
            this.btnPrint.CustomImages.Parent = this.btnPrint;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.HoverState.Parent = this.btnPrint;
            this.btnPrint.Location = new System.Drawing.Point(33, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ShadowDecoration.Parent = this.btnPrint;
            this.btnPrint.Size = new System.Drawing.Size(1057, 93);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Doanh thu tổng";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.chartProducts);
            this.flowLayoutPanel1.Controls.Add(this.chartTotalAmount);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(33, 102);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1080, 634);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // AdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnPrint);
            this.Name = "AdminHomePage";
            this.Size = new System.Drawing.Size(1137, 755);
            ((System.ComponentModel.ISupportInitialize)(this.chartProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalAmount)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartProducts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalAmount;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
