
namespace WebScrapper
{
    partial class MultipleCrawlingForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLinesCount = new System.Windows.Forms.Label();
            this.lblLinesText = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.lblMediaTypes = new System.Windows.Forms.Label();
            this.cmbMediaTypes = new System.Windows.Forms.ComboBox();
            this.lblArticleTypes = new System.Windows.Forms.Label();
            this.cmbArticleTypes = new System.Windows.Forms.ComboBox();
            this.cmbMonthFilter = new System.Windows.Forms.ComboBox();
            this.lblMonthFilter = new System.Windows.Forms.Label();
            this.cmbYearFilter = new System.Windows.Forms.ComboBox();
            this.lblYearFilter = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbStatusValues = new System.Windows.Forms.ListBox();
            this.lblActionLog = new System.Windows.Forms.Label();
            this.progressBarForProcess = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.49553F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.50447F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.Controls.Add(this.btnStart, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxFilter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1088, 556);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStart.Location = new System.Drawing.Point(910, 530);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(175, 23);
            this.btnStart.TabIndex = 15;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLinesCount);
            this.panel1.Controls.Add(this.lblLinesText);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Location = new System.Drawing.Point(910, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 69);
            this.panel1.TabIndex = 12;
            // 
            // lblLinesCount
            // 
            this.lblLinesCount.AutoSize = true;
            this.lblLinesCount.Location = new System.Drawing.Point(90, 54);
            this.lblLinesCount.Name = "lblLinesCount";
            this.lblLinesCount.Size = new System.Drawing.Size(13, 13);
            this.lblLinesCount.TabIndex = 10;
            this.lblLinesCount.Text = "0";
            // 
            // lblLinesText
            // 
            this.lblLinesText.AutoSize = true;
            this.lblLinesText.Location = new System.Drawing.Point(7, 54);
            this.lblLinesText.Name = "lblLinesText";
            this.lblLinesText.Size = new System.Drawing.Size(81, 13);
            this.lblLinesText.TabIndex = 9;
            this.lblLinesText.Text = "Found records: ";
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.Location = new System.Drawing.Point(6, 24);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(99, 24);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBoxFilter
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBoxFilter, 2);
            this.groupBoxFilter.Controls.Add(this.lblMediaTypes);
            this.groupBoxFilter.Controls.Add(this.cmbMediaTypes);
            this.groupBoxFilter.Controls.Add(this.lblArticleTypes);
            this.groupBoxFilter.Controls.Add(this.cmbArticleTypes);
            this.groupBoxFilter.Controls.Add(this.cmbMonthFilter);
            this.groupBoxFilter.Controls.Add(this.lblMonthFilter);
            this.groupBoxFilter.Controls.Add(this.cmbYearFilter);
            this.groupBoxFilter.Controls.Add(this.lblYearFilter);
            this.groupBoxFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFilter.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(901, 69);
            this.groupBoxFilter.TabIndex = 8;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter by ";
            // 
            // lblMediaTypes
            // 
            this.lblMediaTypes.AutoSize = true;
            this.lblMediaTypes.Location = new System.Drawing.Point(2, 28);
            this.lblMediaTypes.Name = "lblMediaTypes";
            this.lblMediaTypes.Size = new System.Drawing.Size(66, 13);
            this.lblMediaTypes.TabIndex = 11;
            this.lblMediaTypes.Text = "Media Type:";
            // 
            // cmbMediaTypes
            // 
            this.cmbMediaTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMediaTypes.FormattingEnabled = true;
            this.cmbMediaTypes.Items.AddRange(new object[] {
            "",
            "Read",
            "Listen",
            "Watch"});
            this.cmbMediaTypes.Location = new System.Drawing.Point(70, 25);
            this.cmbMediaTypes.Name = "cmbMediaTypes";
            this.cmbMediaTypes.Size = new System.Drawing.Size(144, 21);
            this.cmbMediaTypes.TabIndex = 12;
            // 
            // lblArticleTypes
            // 
            this.lblArticleTypes.AutoSize = true;
            this.lblArticleTypes.Location = new System.Drawing.Point(224, 28);
            this.lblArticleTypes.Name = "lblArticleTypes";
            this.lblArticleTypes.Size = new System.Drawing.Size(66, 13);
            this.lblArticleTypes.TabIndex = 9;
            this.lblArticleTypes.Text = "Article Type:";
            // 
            // cmbArticleTypes
            // 
            this.cmbArticleTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArticleTypes.FormattingEnabled = true;
            this.cmbArticleTypes.Items.AddRange(new object[] {
            "",
            "Article",
            "My Devotional",
            "My Journal",
            "Prayer"});
            this.cmbArticleTypes.Location = new System.Drawing.Point(292, 25);
            this.cmbArticleTypes.Name = "cmbArticleTypes";
            this.cmbArticleTypes.Size = new System.Drawing.Size(144, 21);
            this.cmbArticleTypes.TabIndex = 10;
            // 
            // cmbMonthFilter
            // 
            this.cmbMonthFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonthFilter.FormattingEnabled = true;
            this.cmbMonthFilter.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbMonthFilter.Location = new System.Drawing.Point(654, 25);
            this.cmbMonthFilter.Name = "cmbMonthFilter";
            this.cmbMonthFilter.Size = new System.Drawing.Size(72, 21);
            this.cmbMonthFilter.TabIndex = 7;
            // 
            // lblMonthFilter
            // 
            this.lblMonthFilter.AutoSize = true;
            this.lblMonthFilter.Location = new System.Drawing.Point(612, 28);
            this.lblMonthFilter.Name = "lblMonthFilter";
            this.lblMonthFilter.Size = new System.Drawing.Size(40, 13);
            this.lblMonthFilter.TabIndex = 8;
            this.lblMonthFilter.Text = "Month:";
            // 
            // cmbYearFilter
            // 
            this.cmbYearFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYearFilter.FormattingEnabled = true;
            this.cmbYearFilter.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.cmbYearFilter.Location = new System.Drawing.Point(492, 25);
            this.cmbYearFilter.Name = "cmbYearFilter";
            this.cmbYearFilter.Size = new System.Drawing.Size(105, 21);
            this.cmbYearFilter.TabIndex = 1;
            // 
            // lblYearFilter
            // 
            this.lblYearFilter.AutoSize = true;
            this.lblYearFilter.Location = new System.Drawing.Point(454, 28);
            this.lblYearFilter.Name = "lblYearFilter";
            this.lblYearFilter.Size = new System.Drawing.Size(32, 13);
            this.lblYearFilter.TabIndex = 4;
            this.lblYearFilter.Text = "Year:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 2);
            this.dataGridView1.Size = new System.Drawing.Size(579, 475);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.lbStatusValues);
            this.panel2.Controls.Add(this.lblActionLog);
            this.panel2.Controls.Add(this.progressBarForProcess);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(588, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 445);
            this.panel2.TabIndex = 14;
            // 
            // lbStatusValues
            // 
            this.lbStatusValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStatusValues.FormattingEnabled = true;
            this.lbStatusValues.Location = new System.Drawing.Point(0, 38);
            this.lbStatusValues.Name = "lbStatusValues";
            this.lbStatusValues.Size = new System.Drawing.Size(497, 407);
            this.lbStatusValues.TabIndex = 18;
            // 
            // lblActionLog
            // 
            this.lblActionLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblActionLog.Location = new System.Drawing.Point(0, 23);
            this.lblActionLog.Name = "lblActionLog";
            this.lblActionLog.Size = new System.Drawing.Size(497, 15);
            this.lblActionLog.TabIndex = 17;
            this.lblActionLog.Text = "Action log:";
            // 
            // progressBarForProcess
            // 
            this.progressBarForProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBarForProcess.Location = new System.Drawing.Point(0, 0);
            this.progressBarForProcess.Name = "progressBarForProcess";
            this.progressBarForProcess.Size = new System.Drawing.Size(497, 23);
            this.progressBarForProcess.TabIndex = 0;
            // 
            // MultipleCrawlingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 556);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MultipleCrawlingForm";
            this.Text = "Multiple Crawling";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLinesCount;
        private System.Windows.Forms.Label lblLinesText;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Label lblArticleTypes;
        private System.Windows.Forms.ComboBox cmbArticleTypes;
        private System.Windows.Forms.ComboBox cmbMonthFilter;
        private System.Windows.Forms.Label lblMonthFilter;
        private System.Windows.Forms.ComboBox cmbYearFilter;
        private System.Windows.Forms.Label lblYearFilter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblActionLog;
        private System.Windows.Forms.ProgressBar progressBarForProcess;
        private System.Windows.Forms.ListBox lbStatusValues;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblMediaTypes;
        private System.Windows.Forms.ComboBox cmbMediaTypes;
    }
}