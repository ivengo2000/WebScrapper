using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WebScrapper.Models;
using WebScrapper.Services;
using WebScrapper.Utilities;

namespace WebScrapper
{
    public partial class AdjustmentsForm : Form
    {
        private readonly MediaPagesService _mediaPagesService;

        private readonly MarkupService _markupService;

        private readonly AdjustmentsModel.AdjustmentTypes _adjustmentType;

        public List<MediaPageListModel> MediaPages { get; set; }

        public AdjustmentsForm(AdjustmentsModel.AdjustmentTypes adjustmentType)
        {
            InitializeComponent();

            _adjustmentType = adjustmentType;

            InitFormTitle(adjustmentType);

            _mediaPagesService = new MediaPagesService();
            _markupService = new MarkupService();

            Reset();
        }

        private void btnFind_Click(object sender, System.EventArgs e)
        {
            var mediaPageFilterModel = GetMediaPageFilterModel();
            var mediaPages = _mediaPagesService.GetMediaPagesLight(mediaPageFilterModel);

            MediaPages = mediaPages.Pages;

            dataGridView1.DataSource = mediaPages.Pages;

            PrepareGrid();

            lblLinesCount.Text = mediaPages.Total.ToString();
            lblCrawledValue.Text = mediaPages.Crawled.ToString();
            lblNotCrawledValue.Text = mediaPages.NotCrawled.ToString();
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            Reset();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var url = ((DataGridView)sender).CurrentRow?.Cells["Url"].Value.ToString();
            var title = ((DataGridView)sender).CurrentRow?.Cells["PageTitle"].Value.ToString();
            var path = ((DataGridView)sender).CurrentRow?.Cells["Path"].Value.ToString();
            var id = ((DataGridView)sender).CurrentRow?.Cells["Id"].Value.ToString();

            if (!string.IsNullOrEmpty(url) && !string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(path) && !string.IsNullOrEmpty(id))
            {
                var pageMarkup = _mediaPagesService.GetMarkup(id);

                var detailsForm = new MediaPageForm(url, title, path, pageMarkup)
                {
                    MdiParent = this.MdiParent,
                    PageId = id
                };

                detailsForm.Show();
            }
        }

        private void btnProcess_Click(object sender, System.EventArgs e)
        {
            progressBarForProcess.Value = 0;
            btnProcess.Text = @"Running...";
            btnProcess.Enabled = false;

            progressBarForProcess.Maximum = MediaPages.Count;
            lbStatusValues.Items.Clear();

            if (MediaPages != null && MediaPages.Any())
            {
                switch (_adjustmentType)
                {
                    case AdjustmentsModel.AdjustmentTypes.RemoveTagsContent:
                        ProcessAdjustment(_markupService.RemoveTagsContent);
                        break;
                    case AdjustmentsModel.AdjustmentTypes.RemoveMediaTopicTitleContent:
                        ProcessAdjustment(_markupService.RemoveMediaTopicTitleContent);
                        break;
                    case AdjustmentsModel.AdjustmentTypes.RemoveImages:
                        ProcessAdjustment(_markupService.RemoveImages);
                        break;
                    case AdjustmentsModel.AdjustmentTypes.MakeMediaType:
                        ProcessMakeReadMediaTypeAdjustment();
                        break;
                }
            }
            else
            {
                MessageBox.Show(@"Results Are Empty. Find Pages First.");
            }

            btnProcess.Text = @"Run";
            btnProcess.Enabled = true;
        }

        private void InitFormTitle(AdjustmentsModel.AdjustmentTypes adjustmentType)
        {
            switch (adjustmentType)
            {
                case AdjustmentsModel.AdjustmentTypes.RemoveTagsContent:
                    Text += @": Remove Tags Content";
                    break;
                case AdjustmentsModel.AdjustmentTypes.RemoveMediaTopicTitleContent:
                    Text += @": Remove Media Topic Title Content";
                    break;
                case AdjustmentsModel.AdjustmentTypes.RemoveImages:
                    Text += @": Remove Images";
                    break;
                case AdjustmentsModel.AdjustmentTypes.MakeMediaType:
                    Text += @": Make Media Type for already existing 'Read' Media Pages";
                    break;
            }
        }

        private void ProcessAdjustment(Func<string, Tuple<bool, string>> method)
        {
            var i = 0;
            foreach (var mediaPage in MediaPages)
            {
                i++;
                progressBarForProcess.Value = i;
                string statusText;

                var pageMarkup = _mediaPagesService.GetMarkup(mediaPage.Id);
                var updatedMarkupData = method(pageMarkup);

                if (!updatedMarkupData.Item1)
                {
                    statusText = $"Not found or already done before for: {mediaPage.Path}";
                }
                else
                {
                    _mediaPagesService.UpdateMarkup(mediaPage.Id, updatedMarkupData.Item2);

                    statusText = $"Done for: {mediaPage.Path}";
                }

                lbStatusValues.Items.Add(statusText);
                lbStatusValues.Refresh();
            }

            MessageBox.Show(@"Done!");
        }

        private void ProcessMakeReadMediaTypeAdjustment()
        {
            var i = 0;
            foreach (var mediaPage in MediaPages)
            {
                i++;
                progressBarForProcess.Value = i;

                var processResult = _mediaPagesService.MakeReadMediaType(mediaPage.Id);

                var statusText = !processResult 
                    ? $"Not found or already done before for: {mediaPage.Path}" 
                    : $"Done for: {mediaPage.Path}";

                lbStatusValues.Items.Add(statusText);
                lbStatusValues.Refresh();
            }

            MessageBox.Show(@"Done!");
        }

        private void Reset()
        {
            lblLinesCount.Text = @"0";
            lblCrawledValue.Text = @"0";
            lblNotCrawledValue.Text = @"0";

            dataGridView1.ClearSelection();
            dataGridView1.DataSource = null;
            MediaPages = null;

            cmbYearFilter.SelectedItem = null;
            cmbMonthFilter.SelectedItem = null;
            cmbPageTypeFilter.SelectedItem = null;
            tbTitleFilter.Text = null;
        }

        private void PrepareGrid()
        {
            FormsUtilities.SetDtGrdViewColumnVisibility(dataGridView1, "Id");
            FormsUtilities.SetDtGrdViewColumnWidth(dataGridView1, "Url", 450);
            FormsUtilities.SetDtGrdViewColumnWidth(dataGridView1, "Path", 300);
            FormsUtilities.SetDtGrdViewColumnWidth(dataGridView1, "PageTitle", 300);
            FormsUtilities.SetDtGrdViewColumnWidth(dataGridView1, "Year");
            FormsUtilities.SetDtGrdViewColumnWidth(dataGridView1, "Month");
            FormsUtilities.SetDtGrdViewColumnWidth(dataGridView1, "Day");
            FormsUtilities.SetDtGrdViewColumnWidth(dataGridView1, "IsCrawled", 75);
        }

        private MediaPageCommonFilterModel GetMediaPageFilterModel()
        {
            var yearFilter = cmbYearFilter.SelectedItem?.ToString();
            var monthFilter = cmbMonthFilter.SelectedItem?.ToString();
            var mediaPageType = cmbPageTypeFilter.SelectedItem?.ToString();
            var titleFilter = tbTitleFilter.Text;

            var isCrawled = _adjustmentType != AdjustmentsModel.AdjustmentTypes.MakeMediaType ? "Yes" : null;

            return new MediaPageCommonFilterModel(yearFilter, monthFilter, mediaPageType, titleFilter, isCrawled);
        }
    }
}
