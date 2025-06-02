
namespace WebScrapper
{
    partial class SingleCrawlingForm
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
            this.pnlRetrievedMarkup = new System.Windows.Forms.Panel();
            this.rtbPageMarkup = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCopyMarkup = new System.Windows.Forms.Button();
            this.lblPageMarkup = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlSingleUrl.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlUrlTb.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlRetrievedMarkup.SuspendLayout();
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
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 12, 12, 12);
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
            this.pnlUrlTb.Size = new System.Drawing.Size(693, 26);
            this.pnlUrlTb.TabIndex = 4;
            // 
            // tbUrl
            // 
            this.tbUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUrl.Location = new System.Drawing.Point(0, 2);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(683, 20);
            this.tbUrl.TabIndex = 4;
            this.tbUrl.Text = "https://www.ltw.org/read/articles/2024/06/when-your-life-becomes-a-prayer";
            // 
            // btnStartSingle
            // 
            this.btnStartSingle.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStartSingle.Location = new System.Drawing.Point(693, 12);
            this.btnStartSingle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnStartSingle.Name = "btnStartSingle";
            this.btnStartSingle.Size = new System.Drawing.Size(75, 26);
            this.btnStartSingle.TabIndex = 2;
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
            this.lblStatus.Location = new System.Drawing.Point(9, 10);
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
            this.panel1.Controls.Add(this.lblPageMarkup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 346);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlRetrievedMarkup);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 314);
            this.panel2.TabIndex = 7;
            // 
            // pnlRetrievedMarkup
            // 
            this.pnlRetrievedMarkup.Controls.Add(this.rtbPageMarkup);
            this.pnlRetrievedMarkup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRetrievedMarkup.Location = new System.Drawing.Point(0, 0);
            this.pnlRetrievedMarkup.Name = "pnlRetrievedMarkup";
            this.pnlRetrievedMarkup.Size = new System.Drawing.Size(780, 265);
            this.pnlRetrievedMarkup.TabIndex = 10;
            // 
            // rtbPageMarkup
            // 
            this.rtbPageMarkup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPageMarkup.Location = new System.Drawing.Point(0, 0);
            this.rtbPageMarkup.Name = "rtbPageMarkup";
            this.rtbPageMarkup.Size = new System.Drawing.Size(780, 265);
            this.rtbPageMarkup.TabIndex = 6;
            this.rtbPageMarkup.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCopyMarkup);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 265);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(12);
            this.panel3.Size = new System.Drawing.Size(780, 49);
            this.panel3.TabIndex = 9;
            // 
            // btnCopyMarkup
            // 
            this.btnCopyMarkup.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCopyMarkup.Location = new System.Drawing.Point(671, 12);
            this.btnCopyMarkup.Name = "btnCopyMarkup";
            this.btnCopyMarkup.Size = new System.Drawing.Size(97, 25);
            this.btnCopyMarkup.TabIndex = 5;
            this.btnCopyMarkup.Text = "Copy Markup";
            this.btnCopyMarkup.UseVisualStyleBackColor = true;
            this.btnCopyMarkup.Click += new System.EventHandler(this.btnCopyMarkup_Click);
            // 
            // lblPageMarkup
            // 
            this.lblPageMarkup.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPageMarkup.Location = new System.Drawing.Point(0, 0);
            this.lblPageMarkup.Name = "lblPageMarkup";
            this.lblPageMarkup.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblPageMarkup.Size = new System.Drawing.Size(780, 32);
            this.lblPageMarkup.TabIndex = 6;
            this.lblPageMarkup.Text = "Retrieved Markup:";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(10, 118);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(780, 10);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // SingleCrawlingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSingleUrl);
            this.Name = "SingleCrawlingForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Single Crawling";
            this.pnlSingleUrl.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pnlUrlTb.ResumeLayout(false);
            this.pnlUrlTb.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlRetrievedMarkup.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSingleUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPageMarkup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnStartSingle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlUrlTb;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Panel pnlRetrievedMarkup;
        private System.Windows.Forms.RichTextBox rtbPageMarkup;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCopyMarkup;
    }
}

