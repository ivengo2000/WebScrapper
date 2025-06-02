
namespace WebScrapper.GUI.Tools
{
    partial class DbViewForm
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
            this.btnClear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbCrawledFilter = new System.Windows.Forms.ComboBox();
            this.lblCrawledFilter = new System.Windows.Forms.Label();
            this.cmbMonthFilter = new System.Windows.Forms.ComboBox();
            this.lblMonthFilter = new System.Windows.Forms.Label();
            this.tbTitleFilter = new System.Windows.Forms.TextBox();
            this.lblTitleFilter = new System.Windows.Forms.Label();
            this.cmbYearFilter = new System.Windows.Forms.ComboBox();
            this.lblYearFilter = new System.Windows.Forms.Label();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxTotals = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLinesCount = new System.Windows.Forms.Label();
            this.lblLinesText = new System.Windows.Forms.Label();
            this.lblNotCrawledValue = new System.Windows.Forms.Label();
            this.lblNotCrawled = new System.Windows.Forms.Label();
            this.lblCrawledValue = new System.Windows.Forms.Label();
            this.lblCrawled = new System.Windows.Forms.Label();
            this.lblMediaTypes = new System.Windows.Forms.Label();
            this.cmbMediaTypes = new System.Windows.Forms.ComboBox();
            this.lblArticleTypes = new System.Windows.Forms.Label();
            this.cmbArticleTypes = new System.Windows.Forms.ComboBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxFilter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxTotals.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(1449, 364);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmbCrawledFilter
            // 
            this.cmbCrawledFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCrawledFilter.FormattingEnabled = true;
            this.cmbCrawledFilter.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbCrawledFilter.Location = new System.Drawing.Point(1090, 25);
            this.cmbCrawledFilter.Name = "cmbCrawledFilter";
            this.cmbCrawledFilter.Size = new System.Drawing.Size(61, 21);
            this.cmbCrawledFilter.TabIndex = 9;
            // 
            // lblCrawledFilter
            // 
            this.lblCrawledFilter.AutoSize = true;
            this.lblCrawledFilter.Location = new System.Drawing.Point(1040, 28);
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
            this.cmbMonthFilter.Location = new System.Drawing.Point(760, 25);
            this.cmbMonthFilter.Name = "cmbMonthFilter";
            this.cmbMonthFilter.Size = new System.Drawing.Size(75, 21);
            this.cmbMonthFilter.TabIndex = 7;
            // 
            // lblMonthFilter
            // 
            this.lblMonthFilter.AutoSize = true;
            this.lblMonthFilter.Location = new System.Drawing.Point(718, 28);
            this.lblMonthFilter.Name = "lblMonthFilter";
            this.lblMonthFilter.Size = new System.Drawing.Size(40, 13);
            this.lblMonthFilter.TabIndex = 8;
            this.lblMonthFilter.Text = "Month:";
            // 
            // tbTitleFilter
            // 
            this.tbTitleFilter.Location = new System.Drawing.Point(867, 26);
            this.tbTitleFilter.Name = "tbTitleFilter";
            this.tbTitleFilter.Size = new System.Drawing.Size(169, 20);
            this.tbTitleFilter.TabIndex = 2;
            // 
            // lblTitleFilter
            // 
            this.lblTitleFilter.AutoSize = true;
            this.lblTitleFilter.Location = new System.Drawing.Point(838, 28);
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
            this.cmbYearFilter.Location = new System.Drawing.Point(626, 25);
            this.cmbYearFilter.Name = "cmbYearFilter";
            this.cmbYearFilter.Size = new System.Drawing.Size(87, 21);
            this.cmbYearFilter.TabIndex = 1;
            // 
            // lblYearFilter
            // 
            this.lblYearFilter.AutoSize = true;
            this.lblYearFilter.Location = new System.Drawing.Point(593, 28);
            this.lblYearFilter.Name = "lblYearFilter";
            this.lblYearFilter.Size = new System.Drawing.Size(32, 13);
            this.lblYearFilter.TabIndex = 4;
            this.lblYearFilter.Text = "Year:";
            // 
            // groupBoxFilter
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBoxFilter, 2);
            this.groupBoxFilter.Controls.Add(this.lblCategories);
            this.groupBoxFilter.Controls.Add(this.cmbCategory);
            this.groupBoxFilter.Controls.Add(this.lblArticleTypes);
            this.groupBoxFilter.Controls.Add(this.cmbArticleTypes);
            this.groupBoxFilter.Controls.Add(this.lblMediaTypes);
            this.groupBoxFilter.Controls.Add(this.cmbMediaTypes);
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
            this.groupBoxFilter.Size = new System.Drawing.Size(1159, 74);
            this.groupBoxFilter.TabIndex = 4;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter by ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Location = new System.Drawing.Point(1288, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 74);
            this.panel1.TabIndex = 5;
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1455, 450);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // groupBoxTotals
            // 
            this.groupBoxTotals.Controls.Add(this.panel2);
            this.groupBoxTotals.Location = new System.Drawing.Point(1168, 3);
            this.groupBoxTotals.Name = "groupBoxTotals";
            this.groupBoxTotals.Size = new System.Drawing.Size(114, 74);
            this.groupBoxTotals.TabIndex = 6;
            this.groupBoxTotals.TabStop = false;
            this.groupBoxTotals.Text = "Totals";
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
            // lblMediaTypes
            // 
            this.lblMediaTypes.BackColor = System.Drawing.SystemColors.Control;
            this.lblMediaTypes.Location = new System.Drawing.Point(0, 28);
            this.lblMediaTypes.Margin = new System.Windows.Forms.Padding(0);
            this.lblMediaTypes.Name = "lblMediaTypes";
            this.lblMediaTypes.Size = new System.Drawing.Size(69, 13);
            this.lblMediaTypes.TabIndex = 13;
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
            this.cmbMediaTypes.Size = new System.Drawing.Size(132, 21);
            this.cmbMediaTypes.TabIndex = 14;
            // 
            // lblArticleTypes
            // 
            this.lblArticleTypes.AutoSize = true;
            this.lblArticleTypes.Location = new System.Drawing.Point(206, 28);
            this.lblArticleTypes.Margin = new System.Windows.Forms.Padding(0);
            this.lblArticleTypes.Name = "lblArticleTypes";
            this.lblArticleTypes.Size = new System.Drawing.Size(66, 13);
            this.lblArticleTypes.TabIndex = 15;
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
            this.cmbArticleTypes.Location = new System.Drawing.Point(272, 25);
            this.cmbArticleTypes.Name = "cmbArticleTypes";
            this.cmbArticleTypes.Size = new System.Drawing.Size(130, 21);
            this.cmbArticleTypes.TabIndex = 16;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(408, 28);
            this.lblCategories.Margin = new System.Windows.Forms.Padding(0);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(52, 13);
            this.lblCategories.TabIndex = 17;
            this.lblCategories.Text = "Category:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Articles",
            "Events",
            "Interviews",
            "Special Broadcasts",
            "Teaching",
            "Testimonials",
            "Video"});
            this.cmbCategory.Location = new System.Drawing.Point(461, 25);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(127, 21);
            this.cmbCategory.TabIndex = 18;
            // 
            // DbViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DbViewForm";
            this.Text = "Database View";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxTotals.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox groupBoxTotals;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLinesCount;
        private System.Windows.Forms.Label lblLinesText;
        private System.Windows.Forms.Label lblNotCrawledValue;
        private System.Windows.Forms.Label lblNotCrawled;
        private System.Windows.Forms.Label lblCrawledValue;
        private System.Windows.Forms.Label lblCrawled;
        private System.Windows.Forms.Label lblMediaTypes;
        private System.Windows.Forms.ComboBox cmbMediaTypes;
        private System.Windows.Forms.Label lblArticleTypes;
        private System.Windows.Forms.ComboBox cmbArticleTypes;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.ComboBox cmbCategory;
    }
}