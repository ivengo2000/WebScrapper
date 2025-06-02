using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebScrapper.Models;
using WebScrapper.Services;
using WebScrapper.Utilities;

namespace WebScrapper
{
    public partial class MultipleCrawlingForm : Form
    {
        private readonly MediaPagesService _mediaPagesService;

        private readonly MarkupService _markupService;

        public List<MediaPageListBaseModel> Pages { get; set; }

        public MultipleCrawlingForm()
        {
            InitializeComponent();

            _mediaPagesService = new MediaPagesService();
            _markupService = new MarkupService();

            cmbArticleTypes.SelectedIndex = 0;

            Reset();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            progressBarForProcess.Value = 0;
            RefreshData(true);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            progressBarForProcess.Value = 0;
            Reset();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Pages == null|| !Pages.Any())
            {
                MessageBox.Show(@"Find pages first.");

                return;
            }

            btnStart.Text = @"Running...";
            btnStart.Enabled = false;

            progressBarForProcess.Maximum = Pages.Count;
            lbStatusValues.Items.Clear();

            var i = 0;
            foreach (var page in Pages)
            {
                i++;
                progressBarForProcess.Value = i;
                StartProcess(page.Id, page.Url);

            }

            btnStart.Text = @"Start";
            btnStart.Enabled = true;
        }

        private void StartProcess(string pageId, string url)
        {
            var sendRequestModel = _markupService.SendRequest(url);

            var statusText = $@"{sendRequestModel.Url}: {sendRequestModel.StatusCodeText} {sendRequestModel.StatusCode}";

            if (sendRequestModel.StatusCode == HttpStatusCode.OK)
            {
                lblActionLog.ForeColor = SystemColors.ControlText;

                var response = _markupService.GetMarkup(url);

                statusText += @" -> content received";

                var retrievedMarkup = _markupService.ProcessMyDevotionalMarkup(response);

                if (_mediaPagesService.UpdateMarkup(pageId, retrievedMarkup))
                {
                    statusText += @" -> Db: updated";
                }

                else
                {
                    statusText += @" -> Db: page not found";
                }
            }
            else
            {
                statusText += @" -> " + sendRequestModel.StatusCode;
            }

            lbStatusValues.Items.Add(statusText);
            lbStatusValues.Refresh();

            RefreshData();
        }

        private void RefreshData(bool isFirst = false)
        {
            var yearFilter = cmbYearFilter.SelectedItem?.ToString();
            var monthFilter = cmbMonthFilter.SelectedItem?.ToString();
            var articleType = cmbArticleTypes.SelectedItem?.ToString();
            var mediaType = cmbMediaTypes.SelectedItem?.ToString();
            var filterModel = new MediaPageCommonFilterModel(yearFilter, monthFilter, mediaType, articleType);
            var pages = _mediaPagesService.GetMediaPageListForCrawling(filterModel);

            if (isFirst)
            {
                Pages = pages;
                lblLinesCount.Text = Pages.Count.ToString();
            }
            
            dataGridView1.DataSource = pages;
            PrepareGrid();
        }

        private void Reset()
        {
            lblLinesCount.Text = @"0";

            dataGridView1.ClearSelection();
            dataGridView1.DataSource = null;

            cmbYearFilter.SelectedItem = null;
            cmbMonthFilter.SelectedItem = null;
            cmbArticleTypes.SelectedItem = null;
            cmbMediaTypes.SelectedItem = null;

            lblActionLog.Text = string.Empty;
            lblActionLog.ForeColor = SystemColors.ControlText;

            progressBarForProcess.Value = 0;
            btnStart.Text = @"Start";

            lbStatusValues.Items.Clear();
        }

        private void PrepareGrid()
        {
            FormsUtilities.SetDtGrdViewColumnVisibility(dataGridView1, "Id");
            FormsUtilities.SetDtGrdViewColumnWidth(dataGridView1, "Url", 450);
            FormsUtilities.SetDtGrdViewColumnWidth(dataGridView1, "Path", 300);
            FormsUtilities.SetDtGrdViewColumnWidth(dataGridView1, "IsCrawled", 75);
        }

    }
}
