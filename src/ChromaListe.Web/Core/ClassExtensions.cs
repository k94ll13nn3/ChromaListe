using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using Statiq.Common;

namespace ChromaListe.Web.Core;

public static class ClassExtensions
{
    private static IList<PostData>? Posts;
    private static readonly Regex TrimWhitespaces = new(@"\s", RegexOptions.Compiled);
    private static readonly Regex RemoveNonText = new(@"[^\w\s\p{Pd}]", RegexOptions.Compiled);
    private static readonly Regex DashToUnderscores = new("([-_]){2,}", RegexOptions.Compiled);

    [SuppressMessage("Globalization", "CA1308", Justification = "Only for display.")]
    public static string Slugify(this string value)
    {
        _ = value ?? throw new ArgumentNullException(nameof(value));

        value = value.ToLowerInvariant();
        byte[] bytes = CodePagesEncodingProvider.Instance.GetEncoding("Cyrillic")?.GetBytes(value) ?? Array.Empty<byte>();
        value = Encoding.ASCII.GetString(bytes);
        value = TrimWhitespaces.Replace(value, "-");
        value = RemoveNonText.Replace(value, string.Empty);
        value = value.Trim('-', '_');
        value = DashToUnderscores.Replace(value, "$1");

        return value;
    }

    public static string GetDescription(this Enum value, bool shortDescription = false)
    {
        _ = value ?? throw new ArgumentNullException(nameof(value));

        FieldInfo? fi = value.GetType().GetField(value.ToString());

        if (fi is null)
        {
            return value.ToString();
        }

        var attributes = (ChromaDescriptionAttribute[])fi.GetCustomAttributes(typeof(ChromaDescriptionAttribute), false);

        return (attributes?.Length, shortDescription) switch
        {
            ( > 0, true) => attributes[0]!.ShortDescription ?? attributes[0]!.Description,
            ( > 0, false) => attributes[0]!.Description,
            _ => value.ToString(),
        };
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
