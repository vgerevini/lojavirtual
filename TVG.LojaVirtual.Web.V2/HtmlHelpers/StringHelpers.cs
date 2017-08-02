using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;


namespace TVG.LojaVirtual.Web
{
    public static class StringHelpers
    {
        public static string ToSeoUrl(this string url)
        {
            string encodedUrl = (url ?? "").ToLower();

            encodedUrl = Regex.Replace(encodedUrl, @"\&+", "and");
            encodedUrl = Regex.Replace(encodedUrl, "'", "");
            encodedUrl = Regex.Replace(encodedUrl, @"[^a-z0-9]", "-");
            encodedUrl = Regex.Replace(encodedUrl, @"-+", "-");
            encodedUrl = encodedUrl.Trim('-');

            return encodedUrl;
        }
    }
}