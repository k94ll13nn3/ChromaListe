namespace ChromaListe.Web.Pipelines;

internal sealed class CopyResources : Pipeline
{
    public CopyResources()
    {
        Isolated = true;

        ProcessModules =
        [
            new CopyFiles("**/*{!.cshtml,!.md,!.scss,}")
        ];
    }
}
