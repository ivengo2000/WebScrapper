using System;
using System.Windows.Forms;
using WebScrapper.GUI.MediaPages.Listen;
using WebScrapper.GUI.MediaPages.Watch;
using WebScrapper.Models;

namespace WebScrapper.Utilities
{
    public static class FormsUtilities
    {
        public static void ShowForm<T>(Form parentForm) where T : Form
        {
            var aForm = (T)Activator.CreateInstance(typeof(T));
            aForm.MdiParent = parentForm;
            aForm.WindowState = FormWindowState.Maximized;
            aForm.Show();
        }

        public static void ShowAdjustmentsForm(Form parentForm, AdjustmentsModel.AdjustmentTypes adjustmentType)
        {
            var aForm = new AdjustmentsForm(adjustmentType)
            {
                MdiParent = parentForm, 
                WindowState = FormWindowState.Maximized
            };

            aForm.Show();
        }

        public static void ShowListensForm(Form parentForm, ListensModel.CategoryTypes categoryType)
        {
            var aForm = new ListenListingForm(categoryType)
            {
                MdiParent = parentForm,
                WindowState = FormWindowState.Maximized
            };

            aForm.Show();
        }

        public static void ShowWatchesForm(Form parentForm, WatchesModel.CategoryTypes categoryType)
        {
            var aForm = new WatchListingForm(categoryType)
            {
                MdiParent = parentForm,
                WindowState = FormWindowState.Maximized
            };

            aForm.Show();
        }

        public static void SetDtGrdViewColumnVisibility(DataGridView grid, string columnName, bool isVisible = false)
        {
            var column = grid.Columns[columnName];
            if (column != null)
            {
                column.Visible = isVisible;
            }
        }

        public static void SetDtGrdViewColumnWidth(DataGridView grid, string columnName, int width = 50)
        {
            var column = grid.Columns[columnName];
            if (column != null)
            {
                column.Width = width;
            }
        }

        public static string GetFormTitlePostfix(ListensModel.CategoryTypes categoryType)
        {
            var result = string.Empty;

            switch (categoryType)
            {
                case ListensModel.CategoryTypes.Events:
                    result = @": Events";
                    break;
                case ListensModel.CategoryTypes.Interviews:
                    result = @": Interviews";
                    break;
                case ListensModel.CategoryTypes.SpecialBroadcasts:
                    result = @": Special Broadcasts";
                    break;
                case ListensModel.CategoryTypes.Teaching:
                    result = @": Teaching";
                    break;
                case ListensModel.CategoryTypes.UnCategorized:
                    result = @": UnCategorized";
                    break;
            }

            return result;
        }

        public static string GetFormTitlePostfix(WatchesModel.CategoryTypes categoryType)
        {
            var result = string.Empty;

            switch (categoryType)
            {
                case WatchesModel.CategoryTypes.Events:
                    result = @": Events";
                    break;
                case WatchesModel.CategoryTypes.Interviews:
                    result = @": Interviews";
                    break;
                case WatchesModel.CategoryTypes.SpecialBroadcasts:
                    result = @": Special Broadcasts";
                    break;
                case WatchesModel.CategoryTypes.Teaching:
                    result = @": Teaching";
                    break;
                case WatchesModel.CategoryTypes.Testimonials:
                    result = @": Testimonials";
                    break;
                case WatchesModel.CategoryTypes.UnCategorized:
                    result = @": UnCategorized";
                    break;
                case WatchesModel.CategoryTypes.Video:
                    result = @": Video";
                    break;
            }

            return result;
        }
    }
}
