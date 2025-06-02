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

namespace WebScrapper.GUI.Tools
{
    public partial class DbViewForm : Form
    {
        private readonly MediaPagesService _mediaPagesService;

        public DbViewForm()
        {
            InitializeComponent();

            _mediaPagesService = new MediaPagesService();

            Reset();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            var mediaPageFilterModel = GetMediaPageFilterModel();


            var mediaPages = _mediaPagesService.GetMediaPages(mediaPageFilterModel);

            dataGridView1.DataSource = mediaPages.Pages;

            PrepareGrid();

            lblLinesCount.Text = mediaPages.Total.ToString();
            lblCrawledValue.Text = mediaPages.Crawled.ToString();
            lblNotCrawledValue.Text = mediaPages.NotCrawled.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            lblLinesCount.Text = @"0";
            lblCrawledValue.Text = @"0";
            lblNotCrawledValue.Text = @"0";

            dataGridView1.ClearSelection();
            dataGridView1.DataSource = null;

            cmbMediaTypes.SelectedItem = null;
            cmbArticleTypes.SelectedItem = null;
            cmbCategory.SelectedItem = null;

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

        private MediaPageCommonFilterModel GetMediaPageFilterModel()
        {


            var mediaTypeFilter = cmbMediaTypes.SelectedItem?.ToString();
            var articleTypeFilter = cmbArticleTypes.SelectedItem?.ToString();
            var categoryFilter = cmbCategory.SelectedItem?.ToString();
            var yearFilter = cmbYearFilter.SelectedItem?.ToString();
            var monthFilter = cmbMonthFilter.SelectedItem?.ToString();
            var isCrawledFilter = cmbCrawledFilter.SelectedItem?.ToString();
            var titleFilter = tbTitleFilter.Text;

            return new MediaPageCommonFilterModel(yearFilter, monthFilter, mediaTypeFilter, articleTypeFilter, categoryFilter, titleFilter, isCrawledFilter);
        }
    }
}
