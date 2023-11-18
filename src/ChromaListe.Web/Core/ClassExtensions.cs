using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace ChromaListe.Web.Core;

public static partial class ClassExtensions
{
    private static IList<PostData>? Posts;

    public static string Slugify(this string value)
    {
        _ = value ?? throw new ArgumentNullException(nameof(value));

        value = value.ToLowerInvariant();
        byte[] bytes = CodePagesEncodingProvider.Instance.GetEncoding("Cyrillic")?.GetBytes(value) ?? [];
        value = Encoding.ASCII.GetString(bytes);
        value = TrimWhitespaces().Replace(value, "-");
        value = RemoveNonText().Replace(value, string.Empty);
        value = value.Trim('-', '_');
        value = DashToUnderscores().Replace(value, "$1");

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

        Posts ??= context.Outputs
                .FromPipeline(PipelineNames.Posts)
                .OrderByDescending(x => x.Get(CustomKeys.Date))
                .ThenByDescending(x => x.Get(CustomKeys.Number))
                .Select(x => new PostData(x)).ToList();

        return Posts;
    }

    [GeneratedRegex("\\s", RegexOptions.Compiled)]
    private static partial Regex TrimWhitespaces();

    [GeneratedRegex("[^\\w\\s\\p{Pd}]", RegexOptions.Compiled)]
    private static partial Regex RemoveNonText();

    [GeneratedRegex("([-_]){2,}", RegexOptions.Compiled)]
    private static partial Regex DashToUnderscores();
}
