
namespace WebScrapper.GUI.MediaPages
{
    partial class TotalsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartTopLeft = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTopRight = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartBottomLeft = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartBottomRight = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBottomLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBottomRight)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chartBottomRight, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartBottomLeft, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartTopRight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartTopLeft, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 511);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chartTopLeft
            // 
            chartArea4.Name = "ChartArea1";
            this.chartTopLeft.ChartAreas.Add(chartArea4);
            this.chartTopLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chartTopLeft.Legends.Add(legend4);
            this.chartTopLeft.Location = new System.Drawing.Point(3, 3);
            this.chartTopLeft.Name = "chartTopLeft";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartTopLeft.Series.Add(series4);
            this.chartTopLeft.Size = new System.Drawing.Size(394, 249);
            this.chartTopLeft.TabIndex = 0;
            this.chartTopLeft.Text = "chart1";
            title4.Name = "Title1";
            title4.Text = "Totals";
            this.chartTopLeft.Titles.Add(title4);
            // 
            // chartTopRight
            // 
            chartArea3.Name = "ChartArea1";
            this.chartTopRight.ChartAreas.Add(chartArea3);
            this.chartTopRight.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartTopRight.Legends.Add(legend3);
            this.chartTopRight.Location = new System.Drawing.Point(403, 3);
            this.chartTopRight.Name = "chartTopRight";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartTopRight.Series.Add(series3);
            this.chartTopRight.Size = new System.Drawing.Size(394, 249);
            this.chartTopRight.TabIndex = 1;
            this.chartTopRight.Text = "chart1";
            title3.Name = "Title1";
            title3.Text = "Read Pages";
            this.chartTopRight.Titles.Add(title3);
            // 
            // chartBottomLeft
            // 
            chartArea2.Name = "ChartArea1";
            this.chartBottomLeft.ChartAreas.Add(chartArea2);
            this.chartBottomLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartBottomLeft.Legends.Add(legend2);
            this.chartBottomLeft.Location = new System.Drawing.Point(3, 258);
            this.chartBottomLeft.Name = "chartBottomLeft";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartBottomLeft.Series.Add(series2);
            this.chartBottomLeft.Size = new System.Drawing.Size(394, 250);
            this.chartBottomLeft.TabIndex = 2;
            this.chartBottomLeft.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Listen Pages";
            this.chartBottomLeft.Titles.Add(title2);
            // 
            // chartBottomRight
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBottomRight.ChartAreas.Add(chartArea1);
            this.chartBottomRight.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartBottomRight.Legends.Add(legend1);
            this.chartBottomRight.Location = new System.Drawing.Point(403, 258);
            this.chartBottomRight.Name = "chartBottomRight";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartBottomRight.Series.Add(series1);
            this.chartBottomRight.Size = new System.Drawing.Size(394, 250);
            this.chartBottomRight.TabIndex = 3;
            this.chartBottomRight.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Watch Pages";
            this.chartBottomRight.Titles.Add(title1);
            // 
            // TotalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TotalsForm";
            this.Text = "TotalsForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTopLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBottomLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBottomRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopLeft;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopRight;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBottomLeft;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBottomRight;
    }
}