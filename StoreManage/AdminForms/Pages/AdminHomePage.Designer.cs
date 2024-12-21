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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTotalAmount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // chartProducts
            // 
            this.chartProducts.BorderlineColor = System.Drawing.Color.Black;
            this.chartProducts.BorderlineWidth = 3;
            chartArea1.Name = "ChartArea1";
            this.chartProducts.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProducts.Legends.Add(legend1);
            this.chartProducts.Location = new System.Drawing.Point(0, 116);
            this.chartProducts.Name = "chartProducts";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartProducts.Series.Add(series1);
            this.chartProducts.Size = new System.Drawing.Size(557, 500);
            this.chartProducts.TabIndex = 0;
            this.chartProducts.Text = "chart1";
            // 
            // chartTotalAmount
            // 
            this.chartTotalAmount.BorderlineColor = System.Drawing.Color.Black;
            this.chartTotalAmount.BorderlineWidth = 3;
            chartArea2.Name = "ChartArea1";
            this.chartTotalAmount.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTotalAmount.Legends.Add(legend2);
            this.chartTotalAmount.Location = new System.Drawing.Point(563, 116);
            this.chartTotalAmount.Name = "chartTotalAmount";
            this.chartTotalAmount.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTotalAmount.Series.Add(series2);
            this.chartTotalAmount.Size = new System.Drawing.Size(571, 500);
            this.chartTotalAmount.TabIndex = 1;
            this.chartTotalAmount.Text = "chartTotalAmount";
            // 
            // AdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartTotalAmount);
            this.Controls.Add(this.chartProducts);
            this.Name = "AdminHomePage";
            this.Size = new System.Drawing.Size(1137, 755);
            ((System.ComponentModel.ISupportInitialize)(this.chartProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartProducts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalAmount;
    }
}
