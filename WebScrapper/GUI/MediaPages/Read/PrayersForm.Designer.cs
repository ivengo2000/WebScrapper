
namespace WebScrapper
{
    partial class PrayersForm
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
            this.saveFileDialogExportToExcel = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxExport = new System.Windows.Forms.GroupBox();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.lblLinesCount = new System.Windows.Forms.Label();
            this.lblLinesText = new System.Windows.Forms.Label();
            this.lblNotCrawledValue = new System.Windows.Forms.Label();
            this.lblNotCrawled = new System.Windows.Forms.Label();
            this.lblCrawledValue = new System.Windows.Forms.Label();
            this.lblCrawled = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxTotals = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.cmbCrawledFilter = new System.Windows.Forms.ComboBox();
            this.lblCrawledFilter = new System.Windows.Forms.Label();
            this.cmbMonthFilter = new System.Windows.Forms.ComboBox();
            this.lblMonthFilter = new System.Windows.Forms.Label();
            this.tbTitleFilter = new System.Windows.Forms.TextBox();
            this.lblTitleFilter = new System.Windows.Forms.Label();
            this.cmbYearFilter = new System.Windows.Forms.ComboBox();
            this.lblYearFilter = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBoxExport.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxTotals.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialogExportToExcel
            // 
            this.saveFileDialogExportToExcel.Filter = "Excel files|*.xlsx";
            this.saveFileDialogExportToExcel.Title = "Save Data in Excel";
            this.saveFileDialogExportToExcel.ValidateNames = false;
            // 
            // groupBoxExport
            // 
            this.groupBoxExport.Controls.Add(this.btnExportToExcel);
            this.groupBoxExport.Location = new System.Drawing.Point(730, 3);
            this.groupBoxExport.Name = "groupBoxExport";
            this.groupBoxExport.Size = new System.Drawing.Size(79, 74);
            this.groupBoxExport.TabIndex = 7;
            this.groupBoxExport.TabStop = false;
            this.groupBoxExport.Text = "Export";
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(0, 25);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExportToExcel.TabIndex = 13;
            this.btnExportToExcel.Text = "To Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // lblLinesCount
            // 
            this.lblLinesCount.AutoSize = true;
            this.lblLinesCount.Location = new System.Drawing.Point(77, 37);
            this.lblLinesCount.Name = "lblLinesCount";
            this.lblLinesCount.Size = new System.Drawing.Size(13, 13);
            this.lblLinesCount.TabIndex = 16;
            this.lblLinesCount.Text = "0";
            // 
            // lblLinesText
            // 
            this.lblLinesText.AutoSize = true;
            this.lblLinesText.Location = new System.Drawing.Point(11, 37);
            this.lblLinesText.Name = "lblLinesText";
            this.lblLinesText.Size = new System.Drawing.Size(43, 13);
            this.lblLinesText.TabIndex = 15;
            this.lblLinesText.Text = "Found: ";
            // 
            // lblNotCrawledValue
            // 
            this.lblNotCrawledValue.AutoSize = true;
            this.lblNotCrawledValue.Location = new System.Drawing.Point(77, 20);
            this.lblNotCrawledValue.Name = "lblNotCrawledValue";
            this.lblNotCrawledValue.Size = new System.Drawing.Size(13, 13);
            this.lblNotCrawledValue.TabIndex = 14;
            this.lblNotCrawledValue.Text = "0";
            // 
            // lblNotCrawled
            // 
            this.lblNotCrawled.AutoSize = true;
            this.lblNotCrawled.Location = new System.Drawing.Point(12, 20);
            this.lblNotCrawled.Name = "lblNotCrawled";
            this.lblNotCrawled.Size = new System.Drawing.Size(67, 13);
            this.lblNotCrawled.TabIndex = 13;
            this.lblNotCrawled.Text = "Not crawled:";
            // 
            // lblCrawledValue
            // 
            this.lblCrawledValue.AutoSize = true;
            this.lblCrawledValue.Location = new System.Drawing.Point(77, 3);
            this.lblCrawledValue.Name = "lblCrawledValue";
            this.lblCrawledValue.Size = new System.Drawing.Size(13, 13);
            this.lblCrawledValue.TabIndex = 12;
            this.lblCrawledValue.Text = "0";
            // 
            // lblCrawled
            // 
            this.lblCrawled.AutoSize = true;
            this.lblCrawled.Location = new System.Drawing.Point(12, 3);
            this.lblCrawled.Name = "lblCrawled";
            this.lblCrawled.Size = new System.Drawing.Size(48, 13);
            this.lblCrawled.TabIndex = 11;
            this.lblCrawled.Text = "Crawled:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblLinesCount);
            this.panel2.Controls.Add(this.lblLinesText);
            this.panel2.Controls.Add(this.lblNotCrawledValue);
            this.panel2.Controls.Add(this.lblNotCrawled);
            this.panel2.Controls.Add(this.lblCrawledValue);
            this.panel2.Controls.Add(this.lblCrawled);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(108, 55);
            this.panel2.TabIndex = 12;
            // 
            // groupBoxTotals
            // 
            this.groupBoxTotals.Controls.Add(this.panel2);
            this.groupBoxTotals.Location = new System.Drawing.Point(815, 3);
            this.groupBoxTotals.Name = "groupBoxTotals";
            this.groupBoxTotals.Size = new System.Drawing.Size(114, 74);
            this.groupBoxTotals.TabIndex = 6;
            this.groupBoxTotals.TabStop = false;
            this.groupBoxTotals.Text = "Totals";
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.Location = new System.Drawing.Point(4, 25);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxFilter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxTotals, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxExport, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1102, 450);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.cmbCrawledFilter);
            this.groupBoxFilter.Controls.Add(this.lblCrawledFilter);
            this.groupBoxFilter.Controls.Add(this.cmbMonthFilter);
            this.groupBoxFilter.Controls.Add(this.lblMonthFilter);
            this.groupBoxFilter.Controls.Add(this.tbTitleFilter);
            this.groupBoxFilter.Controls.Add(this.lblTitleFilter);
            this.groupBoxFilter.Controls.Add(this.cmbYearFilter);
            this.groupBoxFilter.Controls.Add(this.lblYearFilter);
            this.groupBoxFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFilter.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(721, 74);
            this.groupBoxFilter.TabIndex = 4;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter by ";
            // 
            // cmbCrawledFilter
            // 
            this.cmbCrawledFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCrawledFilter.FormattingEnabled = true;
            this.cmbCrawledFilter.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbCrawledFilter.Location = new System.Drawing.Point(639, 25);
            this.cmbCrawledFilter.Name = "cmbCrawledFilter";
            this.cmbCrawledFilter.Size = new System.Drawing.Size(61, 21);
            this.cmbCrawledFilter.TabIndex = 9;
            // 
            // lblCrawledFilter
            // 
            this.lblCrawledFilter.AutoSize = true;
            this.lblCrawledFilter.Location = new System.Drawing.Point(589, 28);
            this.lblCrawledFilter.Name = "lblCrawledFilter";
            this.lblCrawledFilter.Size = new System.Drawing.Size(48, 13);
            this.lblCrawledFilter.TabIndex = 10;
            this.lblCrawledFilter.Text = "Crawled:";
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
            this.cmbMonthFilter.Location = new System.Drawing.Point(197, 25);
            this.cmbMonthFilter.Name = "cmbMonthFilter";
            this.cmbMonthFilter.Size = new System.Drawing.Size(105, 21);
            this.cmbMonthFilter.TabIndex = 7;
            // 
            // lblMonthFilter
            // 
            this.lblMonthFilter.AutoSize = true;
            this.lblMonthFilter.Location = new System.Drawing.Point(155, 28);
            this.lblMonthFilter.Name = "lblMonthFilter";
            this.lblMonthFilter.Size = new System.Drawing.Size(40, 13);
            this.lblMonthFilter.TabIndex = 8;
            this.lblMonthFilter.Text = "Month:";
            // 
            // tbTitleFilter
            // 
            this.tbTitleFilter.Location = new System.Drawing.Point(341, 26);
            this.tbTitleFilter.Name = "tbTitleFilter";
            this.tbTitleFilter.Size = new System.Drawing.Size(238, 20);
            this.tbTitleFilter.TabIndex = 2;
            // 
            // lblTitleFilter
            // 
            this.lblTitleFilter.AutoSize = true;
            this.lblTitleFilter.Location = new System.Drawing.Point(310, 29);
            this.lblTitleFilter.Name = "lblTitleFilter";
            this.lblTitleFilter.Size = new System.Drawing.Size(30, 13);
            this.lblTitleFilter.TabIndex = 6;
            this.lblTitleFilter.Text = "Title:";
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
            this.cmbYearFilter.Location = new System.Drawing.Point(39, 25);
            this.cmbYearFilter.Name = "cmbYearFilter";
            this.cmbYearFilter.Size = new System.Drawing.Size(105, 21);
            this.cmbYearFilter.TabIndex = 1;
            // 
            // lblYearFilter
            // 
            this.lblYearFilter.AutoSize = true;
            this.lblYearFilter.Location = new System.Drawing.Point(5, 28);
            this.lblYearFilter.Name = "lblYearFilter";
            this.lblYearFilter.Size = new System.Drawing.Size(32, 13);
            this.lblYearFilter.TabIndex = 4;
            this.lblYearFilter.Text = "Year:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 4);
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.Location = new System.Drawing.Point(3, 83);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1096, 364);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Location = new System.Drawing.Point(935, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 74);
            this.panel1.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(88, 25);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // PrayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PrayersForm";
            this.Text = "Prayer Media Pages";
            this.groupBoxExport.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxTotals.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialogExportToExcel;
        private System.Windows.Forms.GroupBox groupBoxExport;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Label lblLinesCount;
        private System.Windows.Forms.Label lblLinesText;
        private System.Windows.Forms.Label lblNotCrawledValue;
        private System.Windows.Forms.Label lblNotCrawled;
        private System.Windows.Forms.Label lblCrawledValue;
        private System.Windows.Forms.Label lblCrawled;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxTotals;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.ComboBox cmbCrawledFilter;
        private System.Windows.Forms.Label lblCrawledFilter;
        private System.Windows.Forms.ComboBox cmbMonthFilter;
        private System.Windows.Forms.Label lblMonthFilter;
        private System.Windows.Forms.TextBox tbTitleFilter;
        private System.Windows.Forms.Label lblTitleFilter;
        private System.Windows.Forms.ComboBox cmbYearFilter;
        private System.Windows.Forms.Label lblYearFilter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
    }
}