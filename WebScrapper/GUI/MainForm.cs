using System;
using System.Windows.Forms;
using WebScrapper.GUI.MediaPages;
using WebScrapper.GUI.Tools;
using WebScrapper.Models;
using WebScrapper.Utilities;

namespace WebScrapper
{
    public partial class MainForm : Form
    {
        public MainForm(bool isAdmin = false)
        {
            InitializeComponent();

            toolStripMenuItemMultipleCrawling.Enabled = isAdmin;
            toolStripMenuItemImportCSV.Enabled = isAdmin;
        }

        private void toolStripMenuItemSingleCrawling_Click(object sender, EventArgs e)
        {
            FormsUtilities.ShowForm<SingleCrawlingForm>(this);
        }

        private void toolStripMenuItemMyDevo_Click(object sender, EventArgs e)
        {
            FormsUtilities.ShowForm<MyDevotionalsForm>(this);
        }

        private void toolStripMenuItemMultipleCrawling_Click(object sender, EventArgs e)
        {
            FormsUtilities.ShowForm<MultipleCrawlingForm>(this);
        }

        private void toolStripMenuItemImportCSV_Click(object sender, EventArgs e)
        {
            FormsUtilities.ShowForm<CSVImportForm>(this);
        }

        private void removeTagsBlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormsUtilities.ShowAdjustmentsForm(this, AdjustmentsModel.AdjustmentTypes.RemoveTagsContent);
        }

        private void removeMediaTopicTitleBlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormsUtilities.ShowAdjustmentsForm(this, AdjustmentsModel.AdjustmentTypes.RemoveMediaTopicTitleContent);
        }

        private void removeImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormsUtilities.ShowAdjustmentsForm(this, AdjustmentsModel.AdjustmentTypes.RemoveImages);
        }

        private void prayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormsUtilities.ShowForm<PrayersForm>(this);
        }

        private void articlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormsUtilities.ShowForm<ArticlesForm>(this);
        }

        private void myJournalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormsUtilities.ShowForm<MyJournalsForm>(this);
        }

        private void makeMediaTypeForExistingReadPagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormsUtilities.ShowAdjustmentsForm(this, AdjustmentsModel.AdjustmentTypes.MakeMediaType);
        }

        private void dbViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormsUtilities.ShowForm<DbViewForm>(this);
        }

        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormsUtilities.ShowListensForm(this, ListensModel.CategoryTypes.Events);
        }

        private void interviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormsUtilities.ShowListensForm(this, ListensModel.CategoryTypes.Interviews);
        }

        private void specialBroadcastsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormsUtilities.ShowListensForm(this, ListensModel.CategoryTypes.SpecialBroadcasts);
        }

        private void teachingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormsUtilities.ShowListensForm(this, ListensModel.CategoryTypes.Teaching);
        }

        private void uncategorizedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormsUtilities.ShowListensForm(this, ListensModel.CategoryTypes.UnCategorized);
        }

        private void eventsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormsUtilities.ShowWatchesForm(this, WatchesModel.CategoryTypes.Events);
        }

        private void interviewsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormsUtilities.ShowWatchesForm(this, WatchesModel.CategoryTypes.Interviews);
        }

        private void specialBroadcastsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormsUtilities.ShowWatchesForm(this, WatchesModel.CategoryTypes.SpecialBroadcasts);
        }

        private void teachingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormsUtilities.ShowWatchesForm(this, WatchesModel.CategoryTypes.Teaching);
        }

        private void testimonialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormsUtilities.ShowWatchesForm(this, WatchesModel.CategoryTypes.Testimonials);
        }

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormsUtilities.ShowWatchesForm(this, WatchesModel.CategoryTypes.Video);
        }

        private void uncategorizedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormsUtilities.ShowWatchesForm(this, WatchesModel.CategoryTypes.UnCategorized);
        }

        private void totalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormsUtilities.ShowForm<TotalsForm>(this);
        }
    }
}
