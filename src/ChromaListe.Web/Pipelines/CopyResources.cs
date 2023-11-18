namespace ChromaListe.Web.Pipelines;

public class CopyResources : Pipeline
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
