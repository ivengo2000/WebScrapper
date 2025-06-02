using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebScrapper.Models;
using WebScrapper.Services;
using WebScrapper.Utilities;

namespace WebScrapper
{
    public partial class MyJournalsForm : Form
    {
        private readonly MediaPagesService _mediaPagesService;

        public MyJournalsForm()
        {
            InitializeComponent();

            _mediaPagesService = new MediaPagesService();

            Reset();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            var mediaPageFilterModel = GetMediaPageFilterModel();
            var myDevotionals = _mediaPagesService.GetMyJournalsLight(mediaPageFilterModel);

            dataGridView1.DataSource = myDevotionals.Pages;

            PrepareGrid();

            lblLinesCount.Text = myDevotionals.Total.ToString();
            lblCrawledValue.Text = myDevotionals.Crawled.ToString();
            lblNotCrawledValue.Text = myDevotionals.NotCrawled.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            var mediaPageFilterModel = GetMediaPageFilterModel();

            var myDevotionals = _mediaPagesService.GetMyJournals(mediaPageFilterModel);

            if (myDevotionals != null && myDevotionals.Any())
            {
                saveFileDialogExportToExcel.FileName = _mediaPagesService.GetInitialExcelFileName(mediaPageFilterModel, Consts.ExportFilePrefixes.MyJournal);

                var result = saveFileDialogExportToExcel.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var fileName = saveFileDialogExportToExcel.FileName;

                    DataUtilities.ExportToExcel(myDevotionals, fileName);
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
                    Text = $@"{Consts.Articles.MyJournal} .:. {path}"
                };

                detailsForm.Show();
            }
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
