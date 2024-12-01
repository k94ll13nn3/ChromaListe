using ChromaListe.Web.Core;

namespace ChromaListe.Web.Modules;

internal sealed class CheckDuplicates : Module
{
    protected override void BeforeExecution(IExecutionContext context)
    {
        var duplicated = context.GetPosts().GroupBy(p => new { p.Number, p.ImageSuffix }).FirstOrDefault(g => g.Count() > 1)?.Key;
        if (duplicated is not null)
        {
            throw new InvalidOperationException($"Duplicated pokémon found! ({duplicated.Number} - {duplicated.ImageSuffix ?? "N/A"})");
        }
    }
}
