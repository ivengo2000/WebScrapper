using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WebScrapper.Models;
using WebScrapper.Models.Totals;
using WebScrapper.Services;
using WebScrapper.Utilities;

namespace WebScrapper.GUI.MediaPages
{
    public partial class TotalsForm : Form
    {
        private readonly MediaPagesService _mediaPagesService;

        private MediaPagesTotalsReturnModel TotalsModel { get; set; }

        public TotalsForm()
        {
            InitializeComponent();

            _mediaPagesService = new MediaPagesService();

            TotalsModel = _mediaPagesService.GetTotals();

            InitChartTopLeft();
            InitChartTopRight();
            InitChartBottomLeft();
            InitChartBottomRight();
        }

        private void InitChartTopLeft()
        {
            var series = new Series("totalSeries") {ChartType = SeriesChartType.Doughnut, IsValueShownAsLabel = true};

            series.Points.AddXY(Consts.MediaTypes.Read, TotalsModel.ReadPagesCount);
            series.Points.AddXY(Consts.MediaTypes.Listen, TotalsModel.ListenPagesCount);
            series.Points.AddXY(Consts.MediaTypes.Watch, TotalsModel.WatchPagesCount);

            chartTopLeft.Series.Add(series);

            chartTopLeft.Legends[0].CustomItems.Add(GetTransparentLegendItem("Total", TotalsModel.Count));
            chartTopLeft.Legends[0].CustomItems.Add(GetTransparentLegendItem("Crawled", TotalsModel.CrawledCount));
            chartTopLeft.Legends[0].CustomItems.Add(GetTransparentLegendItem("Non Crawled", TotalsModel.NonCrawledCount));
        }

        private void InitChartTopRight()
        {
            var series = new Series("totalReadSeries") {ChartType = SeriesChartType.Doughnut, IsValueShownAsLabel = true};

            series.Points.AddXY(Consts.Articles.Article, TotalsModel.ReadTotals.ArticlesCount);
            series.Points.AddXY(Consts.Articles.MyDevotional, TotalsModel.ReadTotals.MyDevotionalsCount);
            series.Points.AddXY(Consts.Articles.MyJournal, TotalsModel.ReadTotals.MyJournalsCount);
            series.Points.AddXY(Consts.Articles.Prayer, TotalsModel.ReadTotals.PrayersCount);

            chartTopRight.Series.Add(series);

            chartTopRight.Legends[0].CustomItems.Add(GetTransparentLegendItem("Total", TotalsModel.ReadTotals.Count));
            chartTopRight.Legends[0].CustomItems.Add(GetTransparentLegendItem("Crawled", TotalsModel.ReadTotals.CrawledCount));
            chartTopRight.Legends[0].CustomItems.Add(GetTransparentLegendItem("Non Crawled", TotalsModel.ReadTotals.NonCrawledCount));
        }

        private void InitChartBottomLeft()
        {
            var series = new Series("totalListenSeries") {ChartType = SeriesChartType.Doughnut, IsValueShownAsLabel = true};

            series.Points.AddXY(Consts.Listens.Events, TotalsModel.ListenTotals.EventsCount);
            series.Points.AddXY(Consts.Listens.Interviews, TotalsModel.ListenTotals.InterviewsCount);
            series.Points.AddXY(Consts.Listens.SpecialBroadcasts, TotalsModel.ListenTotals.SpecialBroadcastsCount);
            series.Points.AddXY(Consts.Listens.Teaching, TotalsModel.ListenTotals.TeachingCount);
            series.Points.AddXY(Consts.Listens.UnCategorized, TotalsModel.ListenTotals.UnCategorizedCount);

            chartBottomLeft.Series.Add(series);

            chartBottomLeft.Legends[0].CustomItems.Add(GetTransparentLegendItem("Total", TotalsModel.ListenTotals.Count));
            chartBottomLeft.Legends[0].CustomItems.Add(GetTransparentLegendItem("Crawled", TotalsModel.ListenTotals.CrawledCount));
            chartBottomLeft.Legends[0].CustomItems.Add(GetTransparentLegendItem("Non Crawled", TotalsModel.ListenTotals.NonCrawledCount));
        }

        private void InitChartBottomRight()
        {
            var series = new Series("totalWatchSeries") { ChartType = SeriesChartType.Doughnut, IsValueShownAsLabel = true };

            series.Points.AddXY(Consts.Watches.Events, TotalsModel.WatchTotals.EventsCount);
            series.Points.AddXY(Consts.Watches.Interviews, TotalsModel.WatchTotals.InterviewsCount);
            series.Points.AddXY(Consts.Watches.SpecialBroadcasts, TotalsModel.WatchTotals.SpecialBroadcastsCount);
            series.Points.AddXY(Consts.Watches.Teaching, TotalsModel.WatchTotals.TeachingCount);
            series.Points.AddXY(Consts.Watches.Testimonials, TotalsModel.WatchTotals.TestimonialsCount);
            series.Points.AddXY(Consts.Watches.UnCategorized, TotalsModel.WatchTotals.UnCategorizedCount);
            series.Points.AddXY(Consts.Watches.Video, TotalsModel.WatchTotals.VideoCount);

            chartBottomRight.Series.Add(series);

            chartBottomRight.Legends[0].CustomItems.Add(GetTransparentLegendItem("Total", TotalsModel.WatchTotals.Count));
            chartBottomRight.Legends[0].CustomItems.Add(GetTransparentLegendItem("Crawled", TotalsModel.WatchTotals.CrawledCount));
            chartBottomRight.Legends[0].CustomItems.Add(GetTransparentLegendItem("Non Crawled", TotalsModel.WatchTotals.NonCrawledCount));
        }

        private LegendItem GetTransparentLegendItem(string title, int value)
        {
            return new LegendItem
            {
                Name = $@"{title}: {value}", 
                BorderColor = Color.Transparent, 
                Color = Color.Transparent
            };
        }
        private Series InitDoughnutSeries(string name, int value)
        {
            var series = new Series(name)
            {
                ChartType = SeriesChartType.Doughnut,
                IsValueShownAsLabel = true
            };

            series.Points.AddXY(name, value);

            return series;
        }
    }
}
