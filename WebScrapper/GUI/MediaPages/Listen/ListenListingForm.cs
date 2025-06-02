using System;
using System.Linq;
using System.Windows.Forms;
using WebScrapper.Models;
using WebScrapper.Services;
using WebScrapper.Utilities;

namespace WebScrapper.GUI.MediaPages.Listen
{
    public partial class ListenListingForm : Form
    {
        private readonly MediaPagesService _mediaPagesService;

        private readonly ListensModel.CategoryTypes _categoryType;

        public ListenListingForm(ListensModel.CategoryTypes categoryType)
        {
            InitializeComponent();

            _categoryType = categoryType;

            InitFormTitle();

            _mediaPagesService = new MediaPagesService();

            Reset();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            var mediaPageFilterModel = GetMediaPageFilterModel();
            var listens = _mediaPagesService.GetListensLight(mediaPageFilterModel, _categoryType);

            dataGridView1.DataSource = listens.Pages;

            PrepareGrid();

            lblLinesCount.Text = listens.Total.ToString();
            lblCrawledValue.Text = listens.Crawled.ToString();
            lblNotCrawledValue.Text = listens.NotCrawled.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            var mediaPageFilterModel = GetMediaPageFilterModel();

            var listens = _mediaPagesService.GetListens(mediaPageFilterModel, _categoryType);

            if (listens != null && listens.Any())
            {
                saveFileDialogExportToExcel.FileName = _mediaPagesService.GetInitialExcelFileName(mediaPageFilterModel, _categoryType);

                var result = saveFileDialogExportToExcel.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var fileName = saveFileDialogExportToExcel.FileName;

                    DataUtilities.ExportToExcel(listens, fileName);
                }
            }
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
                    PageId = id,
                    Text = $@"{Consts.Articles.MyDevotional} .:. {path}"
                };

                detailsForm.Show();
            }
        }

        private void InitFormTitle()
        {
            Text += FormsUtilities.GetFormTitlePostfix(_categoryType);
        }

        private void Reset()
        {
            lblLinesCount.Text = @"0";
            lblCrawledValue.Text = @"0";
            lblNotCrawledValue.Text = @"0";

            dataGridView1.ClearSelection();
            dataGridView1.DataSource = null;

            cmbYearFilter.SelectedItem = null;
            cmbMonthFilter.SelectedItem = null;
            cmbCrawledFilter.SelectedItem = null;
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

        private MediaPageFilterModel GetMediaPageFilterModel()
        {
            var yearFilter = cmbYearFilter.SelectedItem?.ToString();
            var monthFilter = cmbMonthFilter.SelectedItem?.ToString();
            var isCrawledFilter = cmbCrawledFilter.SelectedItem?.ToString();
            var titleFilter = tbTitleFilter.Text;

            return new MediaPageFilterModel(yearFilter, monthFilter, titleFilter, isCrawledFilter);
        }

    }
}
