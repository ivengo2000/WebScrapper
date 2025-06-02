using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using WebScrapper.Services;

namespace WebScrapper
{
    public partial class MediaPageForm : Form
    {
        private readonly MarkupService _markupService;

        private readonly MediaPagesService _mediaPagesService;

        public string PageId { get; set; }

        public MediaPageForm(string url, string title, string path, string pageMarkup) : this(url)
        {
            lblPageTitleValue.Text = title;
            lblPermalinkValue.Text = path;
            rtbPageMarkup.Text = pageMarkup;
        }

        public MediaPageForm(string url)
        {
            InitializeComponent();

            _markupService = new MarkupService();
            _mediaPagesService = new MediaPagesService();

            ResetForm();

            tbUrl.Text = url;

            btnCopyPermalink.Focus();

            // https://www.ltw.org
            // ".page-wrapper.home-page"

            // https://www.ltw.org/read/my-devotional/2024/01/a-firm-foundation
            // ".page-wrapper.media-article"
        }

        #region Events

        private void btnCopyMarkup_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbPageMarkup.Text);
        }

        private void btnStartSingle_Click(object sender, EventArgs e)
        {
            ResetForm();

            StartProcess();
        }

        #endregion Events

        #region Private Methods

        private void ResetForm()
        {
            lblStatusValue.Text = string.Empty;
            lblStatusValue.ForeColor = SystemColors.ControlText;
        }

        private void StartProcess()
        {
            var sendRequestModel = _markupService.SendRequest(tbUrl.Text);

            lblStatusValue.Text = $@"{sendRequestModel.Url}: {sendRequestModel.StatusCodeText} {sendRequestModel.StatusCode}";

            if (sendRequestModel.StatusCode == HttpStatusCode.OK)
            {
                var response = _markupService.GetMarkup(tbUrl.Text);

                lblStatusValue.Text += @" -> content received";

                //rtbPageMarkup.Text = _markupService.ProcessMarkup(response, ".page-wrapper.media-article > div.container.score-page-layout-column2.score-page-layout-large-left > div.score-column2.wide-left > div.score-left");
                rtbPageMarkup.Text = _markupService.ProcessMyDevotionalMarkup(response);
            }
            else
            {
                lblStatusValue.ForeColor = Color.Red;
            }
        }

        #endregion Private Methods

        private void btnCopyPermalink_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblPermalinkValue.Text);
        }

        private void btnCopyPageTitle_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblPageTitleValue.Text);
        }

        private void btnUpdatePageMarkup_Click(object sender, EventArgs e)
        {
            var updateResult = false;
            var pageMarkup = rtbPageMarkup.Text;

            if (!string.IsNullOrWhiteSpace(pageMarkup))
            {
                updateResult = _mediaPagesService.UpdateMarkup(PageId, pageMarkup);
            }

            MessageBox.Show(updateResult
                ? @"Done!"
                : @"Something was wrong. Not saved.");

        }
    }
}
