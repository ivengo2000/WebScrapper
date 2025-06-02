using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using OfficeOpenXml;
using WebScrapper.Helpers;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace WebScrapper.Utilities
{
    public static class DataUtilities
    {
        public static DataTable ReadCsvFile(OpenFileDialog openFileDialog)
        {
            var dt = new DataTable();

            try
            {
                var fileStream = openFileDialog.OpenFile();
                using (var streamReader = new StreamReader(fileStream))
                {
                    while (!streamReader.EndOfStream)
                    {
                        // string[] lineSeparators = { "\r\n" };
                        string[] lineSeparators = { "\"\r\n" };
                        string[] columnSeparators = { "\",\"" };
                        
                        var text = streamReader.ReadToEnd();

                        text = StringUtility.RemoveLineBreaksBetweenTags(text);

                       var rows = text.Split(lineSeparators, StringSplitOptions.None);
                       // var rows = text.ToString().Split(lineSeparators, StringSplitOptions.None);
                        if (rows.Length > 0)
                        {
                            //Add columns
                            // var columns = rows[0].Trim('"').Split(columnSeparators, StringSplitOptions.None);
                            var columns = rows[0].TrimStart('"').Split(columnSeparators, StringSplitOptions.None);
                            for (var j = 0; j < columns.Count(); j++)
                            {
                                dt.Columns.Add(columns[j]);
                            }

                            //Add rows
                            for (var i = 1; i <= rows.Length - 1; i++)
                            {
                                // string[] data = rows[i].Split(',');
                                // var data = rows[i].Trim('"').Split(columnSeparators, StringSplitOptions.None);
                                var data = rows[i].TrimStart('"').Split(columnSeparators, StringSplitOptions.None);
                                var dr = dt.NewRow();
                                for (var k = 0; k < data.Length; k++)
                                {
                                    dr[k] = data[k];
                                }

                                dt.Rows.Add(dr);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($@"Message: {e.Message}.", @"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        // function that creates a list of an object from the given data table
        public static List<T> CreateObjectListFromTable<T>(DataTable tbl) where T : new()
        {
            // define return list
            List<T> lst = new List<T>();

            // go through each row
            foreach (DataRow r in tbl.Rows)
            {
                // add to the list
                lst.Add(CreateItemFromRow<T>(r));
            }

            // return the list
            return lst;
        }

        // function that creates an object from the given data row
        public static T CreateItemFromRow<T>(DataRow row) where T : new()
        {
            // create a new object
            T item = new T();

            // set the item
            SetItemFromRow(item, row);

            // return 
            return item;
        }

        public static void SetItemFromRow<T>(T item, DataRow row) where T : new()
        {
            var properties = item.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

            // go through each column
            foreach (DataColumn c in row.Table.Columns)
            {
                // find the property for the column
                var p = item.GetType().GetProperty(c.ColumnName, BindingFlags.Public | BindingFlags.Instance);
                if (p == null)
                {
                    foreach (var property in properties)
                    {
                        var attribute = property.GetCustomAttributes(typeof(FieldNameAttribute), false)
                            .Select(x => x as FieldNameAttribute).ToList().Where(x => x.Name.Equals(c.ColumnName));

                        if (attribute.Any())
                        {
                            p = property;
                        }
                    }
                }

                // if exists, set the value
                if (p != null && row[c] != DBNull.Value)
                {
                    p.SetValue(item, row[c], null);
                }
            }
        }

        public static void ExportToExcel<T>(List<T> dataList, string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                // Add headers
                for (int i = 0; i < typeof(T).GetProperties().Length; i++)
                {
                    worksheet.Cells[1, i + 1].Value = typeof(T).GetProperties()[i].Name;
                }

                // Add data
                for (int i = 0; i < dataList.Count; i++)
                {
                    for (int j = 0; j < typeof(T).GetProperties().Length; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = typeof(T).GetProperties()[j].GetValue(dataList[i]);
                    }
                }

                // Save the file
                var fi = new FileInfo(filePath);
                package.SaveAs(fi);
            }
        }
    }
}
