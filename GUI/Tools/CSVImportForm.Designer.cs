
namespace WebScrapper
{
    partial class CSVImportForm
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
            this.openCSVFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbMediaTypes = new System.Windows.Forms.ComboBox();
            this.lblMediaTypes = new System.Windows.Forms.Label();
            this.btnOpenCSV = new System.Windows.Forms.Button();
            this.btnSaveToDb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openCSVFileDialog
            // 
            this.openCSVFileDialog.FileName = "openCSVFileDialog";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 360);
            this.dataGridView1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnOpenCSV, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 426);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveToDb);
            this.panel1.Controls.Add(this.cmbMediaTypes);
            this.panel1.Controls.Add(this.lblMediaTypes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(408, 399);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 24);
            this.panel1.TabIndex = 24;
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
            this.cmbMediaTypes.Location = new System.Drawing.Point(127, 2);
            this.cmbMediaTypes.Name = "cmbMediaTypes";
            this.cmbMediaTypes.Size = new System.Drawing.Size(144, 21);
            this.cmbMediaTypes.TabIndex = 21;
            // 
            // lblMediaTypes
            // 
            this.lblMediaTypes.AutoSize = true;
            this.lblMediaTypes.Location = new System.Drawing.Point(55, 6);
            this.lblMediaTypes.Name = "lblMediaTypes";
            this.lblMediaTypes.Size = new System.Drawing.Size(66, 13);
            this.lblMediaTypes.TabIndex = 20;
            this.lblMediaTypes.Text = "Media Type:";
            // 
            // btnOpenCSV
            // 
            this.btnOpenCSV.Location = new System.Drawing.Point(3, 3);
            this.btnOpenCSV.Name = "btnOpenCSV";
            this.btnOpenCSV.Size = new System.Drawing.Size(75, 24);
            this.btnOpenCSV.TabIndex = 23;
            this.btnOpenCSV.Text = "Open a CSV";
            this.btnOpenCSV.UseVisualStyleBackColor = true;
            this.btnOpenCSV.Click += new System.EventHandler(this.btnOpenCSV_Click);
            // 
            // btnSaveToDb
            // 
            this.btnSaveToDb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveToDb.Location = new System.Drawing.Point(291, 0);
            this.btnSaveToDb.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaveToDb.Name = "btnSaveToDb";
            this.btnSaveToDb.Size = new System.Drawing.Size(75, 24);
            this.btnSaveToDb.TabIndex = 22;
            this.btnSaveToDb.Text = "Save Data";
            this.btnSaveToDb.UseVisualStyleBackColor = true;
            this.btnSaveToDb.Click += new System.EventHandler(this.btnSaveToDb_Click);
            // 
            // CSVImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CSVImportForm";
            this.Text = "Import Form CSV";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openCSVFileDialog;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbMediaTypes;
        private System.Windows.Forms.Label lblMediaTypes;
        private System.Windows.Forms.Button btnOpenCSV;
        private System.Windows.Forms.Button btnSaveToDb;
    }
}