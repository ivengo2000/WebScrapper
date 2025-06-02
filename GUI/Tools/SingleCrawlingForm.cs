using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using WebScrapper.Services;

namespace WebScrapper
{
    public partial class SingleCrawlingForm : Form
    {
        private readonly MarkupService _markupService;

        public SingleCrawlingForm()
        {
            InitializeComponent();

            _markupService = new MarkupService();

            ResetForm();

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

            rtbPageMarkup.Text = string.Empty;
        }

        private void StartProcess()
        {
            var sendRequestModel = _markupService.SendRequest(tbUrl.Text);

            lblStatusValue.Text = $@"{sendRequestModel.Url}: {sendRequestModel.StatusCodeText} {sendRequestModel.StatusCode}";

            if (sendRequestModel.StatusCode == HttpStatusCode.OK)
            {
                var response = _markupService.GetMarkup(tbUrl.Text);

                lblStatusValue.Text += @" -> content received";

                rtbPageMarkup.Text = _markupService.ProcessMyDevotionalMarkup(response);
            }
            else
            {
                lblStatusValue.ForeColor = Color.Red;
            }
        }

        #endregion Private Methods
    }
}
