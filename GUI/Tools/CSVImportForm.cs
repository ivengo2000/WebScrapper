using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LiteDB;
using WebScrapper.Models;
using WebScrapper.Services;
using WebScrapper.Utilities;

namespace WebScrapper
{
    public partial class CSVImportForm : Form
    {
        private readonly MediaPagesService _mediaPagesService;

        public CSVImportForm()
        {
            InitializeComponent();

            _mediaPagesService = new MediaPagesService();

            openCSVFileDialog.Filter = @"CSV files (*.csv)|*.csv";
        }

        private void btnOpenCSV_Click(object sender, EventArgs e)
        {
            if (openCSVFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var dt = DataUtilities.ReadCsvFile(openCSVFileDialog);

                    var model = DataUtilities.CreateObjectListFromTable<MediaPageModel>(dt);

                    var dbModel = _mediaPagesService.CorrectValuesForMediaPage(model);

                    dataGridView1.DataSource = dbModel;
                }
                catch (Exception exception)
                {
                    MessageBox.Show($@"Message: {exception.Message}.", @"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaveToDb_Click(object sender, EventArgs e)
        {
            var mediaType = cmbMediaTypes.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(mediaType))
            {
                MessageBox.Show(@"Message: No selected Media Type. That's mandatory.", @"WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            var modelList = dataGridView1.DataSource as List<MediaPagesDbModel>;
            if (modelList == null || !modelList.Any())
            {
                MessageBox.Show(@"Message: No data.", @"WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            var result = _mediaPagesService.AddToDb(modelList, mediaType);
            if (result)
            {
                MessageBox.Show(@"Done!", @"SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(@"Something was wrong. Not saved.", @"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
