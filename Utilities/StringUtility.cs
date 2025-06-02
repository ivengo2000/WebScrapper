using System.Text.RegularExpressions;

namespace WebScrapper.Utilities
{
    public static class StringUtility
    {
        public static string CompressHtmlToSingleLine(string html)
        {
            // Remove newlines, carriage returns, and excess spaces between tags
            string compressedHtml = Regex.Replace(html, @"\s+", " "); // Replace multiple spaces with one
            compressedHtml = Regex.Replace(compressedHtml, @"\s*(<[^>]+>)\s*", "$1"); // Remove spaces around tags

            return compressedHtml.Trim();
        }

        public static string RemoveLineBreaksBetweenTags(string html)
        {
            // Use a regular expression to remove CR/LF between tags
            var cleanedHtml = Regex.Replace(html, @">\s*(\r\n|\n|\r)\s*<", "><");

            cleanedHtml = Regex.Replace(cleanedHtml, @">\s*(\r\n|\n|\r)\s*", ">");

            cleanedHtml = cleanedHtml.Replace("\r\n<", "<");

            return cleanedHtml;
        }
    }
}
