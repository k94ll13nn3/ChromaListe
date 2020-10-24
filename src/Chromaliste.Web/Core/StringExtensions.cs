using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ChromaListe.Web.Core
{
    public static class StringExtensions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1308", Justification = "Only for display.")]
        public static string Slugify(this string value)
        {
            _ = value ?? throw new ArgumentNullException(nameof(value));

            value = value.ToLowerInvariant();
            byte[] bytes = CodePagesEncodingProvider.Instance.GetEncoding("Cyrillic")?.GetBytes(value) ?? Array.Empty<byte>();
            value = Encoding.ASCII.GetString(bytes);
            value = Regex.Replace(value, @"\s", "-", RegexOptions.Compiled);
            value = Regex.Replace(value, @"[^\w\s\p{Pd}]", string.Empty, RegexOptions.Compiled);
            value = value.Trim('-', '_');
            value = Regex.Replace(value, "([-_]){2,}", "$1", RegexOptions.Compiled);

            return value;
        }
    }
}
