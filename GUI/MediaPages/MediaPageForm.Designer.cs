
namespace WebScrapper
{
    partial class MediaPageForm
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
            this.pnlSingleUrl = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlUrlTb = new System.Windows.Forms.Panel();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btnStartSingle = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPageMarkup = new System.Windows.Forms.Label();
            this.rtbPageMarkup = new System.Windows.Forms.RichTextBox();
            this.btnCopyPageTitle = new System.Windows.Forms.Button();
            this.btnCopyPermalink = new System.Windows.Forms.Button();
            this.lblPermalink = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPermalinkValue = new System.Windows.Forms.Label();
            this.lblPageTitleValue = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUpdatePageMarkup = new System.Windows.Forms.Button();
            this.btnCopyMarkup = new System.Windows.Forms.Button();
            this.pnlSingleUrl.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlUrlTb.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSingleUrl
            // 
            this.pnlSingleUrl.Controls.Add(this.panel5);
            this.pnlSingleUrl.Controls.Add(this.panel4);
            this.pnlSingleUrl.Controls.Add(this.lblUrl);
            this.pnlSingleUrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSingleUrl.Location = new System.Drawing.Point(10, 10);
            this.pnlSingleUrl.Name = "pnlSingleUrl";
            this.pnlSingleUrl.Size = new System.Drawing.Size(780, 108);
            this.pnlSingleUrl.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pnlUrlTb);
            this.panel5.Controls.Add(this.btnStartSingle);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 26);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 12, 2, 12);
            this.panel5.Size = new System.Drawing.Size(780, 50);
            this.panel5.TabIndex = 6;
            // 
            // pnlUrlTb
            // 
            this.pnlUrlTb.Controls.Add(this.tbUrl);
            this.pnlUrlTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUrlTb.Location = new System.Drawing.Point(0, 12);
            this.pnlUrlTb.Name = "pnlUrlTb";
            this.pnlUrlTb.Padding = new System.Windows.Forms.Padding(0, 2, 10, 0);
            this.pnlUrlTb.Size = new System.Drawing.Size(703, 26);
            this.pnlUrlTb.TabIndex = 4;
            // 
            // tbUrl
            // 
            this.tbUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUrl.Location = new System.Drawing.Point(0, 2);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.ReadOnly = true;
            this.tbUrl.Size = new System.Drawing.Size(693, 20);
            this.tbUrl.TabIndex = 4;
            this.tbUrl.TabStop = false;
            this.tbUrl.Text = "https://www.ltw.org/read/articles/2024/06/when-your-life-becomes-a-prayer";
            // 
            // btnStartSingle
            // 
            this.btnStartSingle.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStartSingle.Location = new System.Drawing.Point(703, 12);
            this.btnStartSingle.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnStartSingle.Name = "btnStartSingle";
            this.btnStartSingle.Size = new System.Drawing.Size(75, 26);
            this.btnStartSingle.TabIndex = 4;
            this.btnStartSingle.Text = "Start";
            this.btnStartSingle.UseVisualStyleBackColor = true;
            this.btnStartSingle.Click += new System.EventHandler(this.btnStartSingle_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblStatusValue);
            this.panel4.Controls.Add(this.lblStatus);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(780, 32);
            this.panel4.TabIndex = 5;
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.AutoSize = true;
            this.lblStatusValue.Location = new System.Drawing.Point(55, 10);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(62, 13);
            this.lblStatusValue.TabIndex = 5;
            this.lblStatusValue.Text = "statusValue";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(2, 10);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status:";
            // 
            // lblUrl
            // 
            this.lblUrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUrl.Location = new System.Drawing.Point(0, 0);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblUrl.Size = new System.Drawing.Size(780, 26);
            this.lblUrl.TabIndex = 2;
            this.lblUrl.Text = "URL:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 346);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 346);
            this.panel2.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Controls.Add(this.lblPageMarkup, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.rtbPageMarkup, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnCopyPageTitle, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCopyPermalink, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPermalink, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPageTitle, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblPermalinkValue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPageTitleValue, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 300);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // lblPageMarkup
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lblPageMarkup, 2);
            this.lblPageMarkup.Location = new System.Drawing.Point(3, 119);
            this.lblPageMarkup.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lblPageMarkup.Name = "lblPageMarkup";
            this.lblPageMarkup.Size = new System.Drawing.Size(153, 13);
            this.lblPageMarkup.TabIndex = 14;
            this.lblPageMarkup.Text = "Retrieved Markup:";
            // 
            // rtbPageMarkup
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.rtbPageMarkup, 3);
            this.rtbPageMarkup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPageMarkup.Location = new System.Drawing.Point(3, 136);
            this.rtbPageMarkup.Name = "rtbPageMarkup";
            this.rtbPageMarkup.Size = new System.Drawing.Size(774, 161);
            this.rtbPageMarkup.TabIndex = 13;
            this.rtbPageMarkup.TabStop = false;
            this.rtbPageMarkup.Text = "";
            // 
            // btnCopyPageTitle
            // 
            this.btnCopyPageTitle.Location = new System.Drawing.Point(703, 69);
            this.btnCopyPageTitle.Name = "btnCopyPageTitle";
            this.btnCopyPageTitle.Size = new System.Drawing.Size(74, 21);
            this.btnCopyPageTitle.TabIndex = 2;
            this.btnCopyPageTitle.Text = "Copy";
            this.btnCopyPageTitle.UseVisualStyleBackColor = true;
            this.btnCopyPageTitle.Click += new System.EventHandler(this.btnCopyPageTitle_Click);
            // 
            // btnCopyPermalink
            // 
            this.btnCopyPermalink.Location = new System.Drawing.Point(703, 19);
            this.btnCopyPermalink.Name = "btnCopyPermalink";
            this.btnCopyPermalink.Size = new System.Drawing.Size(74, 21);
            this.btnCopyPermalink.TabIndex = 1;
            this.btnCopyPermalink.Text = "Copy";
            this.btnCopyPermalink.UseVisualStyleBackColor = true;
            this.btnCopyPermalink.Click += new System.EventHandler(this.btnCopyPermalink_Click);
            // 
            // lblPermalink
            // 
            this.lblPermalink.AutoSize = true;
            this.lblPermalink.Location = new System.Drawing.Point(3, 22);
            this.lblPermalink.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lblPermalink.Name = "lblPermalink";
            this.lblPermalink.Size = new System.Drawing.Size(56, 13);
            this.lblPermalink.TabIndex = 4;
            this.lblPermalink.Text = "Permalink:";
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Location = new System.Drawing.Point(3, 72);
            this.lblPageTitle.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(58, 13);
            this.lblPageTitle.TabIndex = 5;
            this.lblPageTitle.Text = "Page Title:";
            // 
            // lblPermalinkValue
            // 
            this.lblPermalinkValue.AutoSize = true;
            this.lblPermalinkValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPermalinkValue.Location = new System.Drawing.Point(73, 22);
            this.lblPermalinkValue.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lblPermalinkValue.Name = "lblPermalinkValue";
            this.lblPermalinkValue.Size = new System.Drawing.Size(624, 21);
            this.lblPermalinkValue.TabIndex = 6;
            this.lblPermalinkValue.Text = "lblPermalinkValue";
            // 
            // lblPageTitleValue
            // 
            this.lblPageTitleValue.AutoSize = true;
            this.lblPageTitleValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPageTitleValue.Location = new System.Drawing.Point(73, 72);
            this.lblPageTitleValue.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lblPageTitleValue.Name = "lblPageTitleValue";
            this.lblPageTitleValue.Size = new System.Drawing.Size(624, 21);
            this.lblPageTitleValue.TabIndex = 7;
            this.lblPageTitleValue.Text = "lblPageTitleValue";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnUpdatePageMarkup);
            this.panel3.Controls.Add(this.btnCopyMarkup);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 300);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10, 10, 2, 10);
            this.panel3.Size = new System.Drawing.Size(780, 46);
            this.panel3.TabIndex = 9;
            // 
            // btnUpdatePageMarkup
            // 
            this.btnUpdatePageMarkup.Location = new System.Drawing.Point(1, 11);
            this.btnUpdatePageMarkup.Name = "btnUpdatePageMarkup";
            this.btnUpdatePageMarkup.Size = new System.Drawing.Size(120, 26);
            this.btnUpdatePageMarkup.TabIndex = 6;
            this.btnUpdatePageMarkup.Text = "Update Markup in Db";
            this.btnUpdatePageMarkup.UseVisualStyleBackColor = true;
            this.btnUpdatePageMarkup.Click += new System.EventHandler(this.btnUpdatePageMarkup_Click);
            // 
            // btnCopyMarkup
            // 
            this.btnCopyMarkup.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCopyMarkup.Location = new System.Drawing.Point(681, 10);
            this.btnCopyMarkup.Name = "btnCopyMarkup";
            this.btnCopyMarkup.Size = new System.Drawing.Size(97, 26);
            this.btnCopyMarkup.TabIndex = 3;
            this.btnCopyMarkup.Text = "Copy Markup";
            this.btnCopyMarkup.UseVisualStyleBackColor = true;
            this.btnCopyMarkup.Click += new System.EventHandler(this.btnCopyMarkup_Click);
            // 
            // MyDevotionalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSingleUrl);
            this.Name = "MyDevotionalForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "My Devotional";
            this.pnlSingleUrl.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pnlUrlTb.ResumeLayout(false);
            this.pnlUrlTb.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSingleUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnStartSingle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlUrlTb;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCopyMarkup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCopyPageTitle;
        private System.Windows.Forms.Button btnCopyPermalink;
        private System.Windows.Forms.Label lblPermalink;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPermalinkValue;
        private System.Windows.Forms.Label lblPageTitleValue;
        private System.Windows.Forms.Label lblPageMarkup;
        private System.Windows.Forms.RichTextBox rtbPageMarkup;
        private System.Windows.Forms.Button btnUpdatePageMarkup;
    }
}