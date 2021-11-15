using HiQPdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PMQLKS
{
    public class PdfUtils
    {
        private const string HiQKey = "YCgJMTAE-BiwJAhIB-EhlRUE5R-V0BRQFFA-UEBTUU5R-Uk5ZWVlZ";
        public static readonly int MAX_SOURCE_SIZE = 2097152;

        public static byte[] ExecuteGenPdfBytes(string html, string paperSize, bool withoutPrintStyle = false)
        {
            HtmlToPdf hiQ = new HtmlToPdf();
            switch (paperSize)
            {
                case "A5":
                    hiQ.Document.PageSize = PdfPageSize.A5;
                    hiQ.Document.PageOrientation = PdfPageOrientation.Landscape;
                    hiQ.BrowserWidth = 890;
                    hiQ.Document.Margins.Top = 25;
                    hiQ.Document.Margins.Bottom = 10;
                    break;
                default:
                    hiQ.Document.PageSize = PdfPageSize.A4;
                    hiQ.Document.PageOrientation = PdfPageOrientation.Portrait;
                    hiQ.BrowserWidth = 890;
                    hiQ.Document.Margins.Top = 25;
                    hiQ.Document.Margins.Bottom = 10;
                    break;
            }

            hiQ.TriggerMode = ConversionTriggerMode.WaitTime;
            hiQ.SerialNumber = HiQKey;
            hiQ.Document.FitPageWidth = true;
            hiQ.Document.FitPageHeight = true;
            return withoutPrintStyle ? hiQ.ConvertHtmlToMemory(html, "") : hiQ.ConvertHtmlToMemory(AddPrintStyle(html), "");
        }

        public static void GetPdfBytes(string html, string baseUrl, Stream stream)
        {
            HtmlToPdf hiQ = new HtmlToPdf();
            hiQ.SerialNumber = HiQKey;
            hiQ.Document.PageSize = PdfPageSize.A5;
            hiQ.Document.PageOrientation = PdfPageOrientation.Portrait;
            hiQ.BrowserWidth = 970;
            hiQ.Document.Margins.Top = 20;
            hiQ.Document.Margins.Bottom = 10;
            hiQ.Document.FitPageWidth = true;
            hiQ.ConvertHtmlToStream(html, baseUrl, stream);
        }

        public static void GetPdfBytesToFilePath(string html, string filePath)
        {
            HtmlToPdf hiQ = new HtmlToPdf();
            hiQ.SerialNumber = HiQKey;
            hiQ.Document.PageSize = PdfPageSize.A5;
            hiQ.Document.PageOrientation = PdfPageOrientation.Portrait;
            hiQ.BrowserWidth = 970;
            hiQ.Document.Margins.Top = 20;
            hiQ.Document.Margins.Bottom = 10;
            hiQ.Document.FitPageWidth = true;
            hiQ.ConvertHtmlToFile(html, null, filePath);
        }

        public static byte[] ConvertHtmlToMemory(string html, string baseUrl)
        {
            HtmlToPdf hiQ = new HtmlToPdf();
            hiQ.SerialNumber = HiQKey;
            hiQ.Document.PageSize = PdfPageSize.A5;
            hiQ.Document.PageOrientation = PdfPageOrientation.Landscape;
            hiQ.BrowserWidth = 970;
            hiQ.Document.Margins.Top = 20;
            hiQ.Document.Margins.Bottom = 10;
            hiQ.Document.FitPageWidth = true;
            return hiQ.ConvertHtmlToMemory(AddPrintStyle(html), baseUrl);
        }

        private static string AddPrintStyle(string html)
        {
            string pattern = @"(.VATTEMP)(\s*{)([^{}]*)(;\s)*(})";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(html);
            if (matches.Count > 0)
            {
                int i = 0;
                foreach (Match match in matches)
                {
                    if (Regex.IsMatch(match.Value, @"margin\s*:"))
                        i = -1;
                }
                if (i != -1)
                {
                    string vMatch = matches[0].Value;
                    string rs = Regex.Replace(vMatch, pattern, m => string.Format(
                                    "{0}{1}{2}{3}{4}",
                                    m.Groups[1].Value,
                                    m.Groups[2].Value,
                                    m.Groups[3].Value,
                                    "; margin: 0 auto;",
                                    m.Groups[5].Value));
                    html = html.Replace(vMatch, rs);
                }
            }
            return html;
        }

        public static byte[] GetImageBytes(string html)
        {
            HtmlToImage hiQ = new HtmlToImage();
            hiQ.TriggerMode = ConversionTriggerMode.WaitTime;
            hiQ.SerialNumber = HiQKey;
            hiQ.BrowserWidth = 970;
            hiQ.TransparentImage = false;
            return hiQ.ConvertHtmlToMemory(html, "");
        }

    }
}
