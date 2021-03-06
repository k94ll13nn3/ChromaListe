﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using Statiq.Common;

namespace ChromaListe.Web.Core
{
    public static class ClassExtensions
    {
        private static IList<PostData>? Posts;

        [SuppressMessage("Globalization", "CA1308", Justification = "Only for display.")]
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

        public static string GetDescription(this Enum value)
        {
            _ = value ?? throw new ArgumentNullException(nameof(value));

            FieldInfo? fi = value.GetType().GetField(value.ToString());

            if (fi is null)
            {
                return value.ToString();
            }

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes?.Length > 0 ? attributes[0].Description : value.ToString();
        }

        public static IList<PostData> GetPosts(this IExecutionContext context)
        {
            _ = context ?? throw new ArgumentNullException(nameof(context));

            if (Posts is null)
            {
                Posts = context.Outputs
                    .FromPipeline(PipelineNames.Posts)
                    .OrderByDescending(x => x.Get(CustomKeys.Date))
                    .ThenByDescending(x => x.Get(CustomKeys.Number))
                    .Select(x => new PostData(x)).ToList();
            }

            return Posts;
        }
    }
}
