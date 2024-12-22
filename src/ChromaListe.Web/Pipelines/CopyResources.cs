namespace ChromaListe.Web.Pipelines;

public sealed class CopyResources : Pipeline
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
