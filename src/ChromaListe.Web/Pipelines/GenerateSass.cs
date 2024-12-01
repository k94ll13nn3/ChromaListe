using Statiq.Sass;

namespace ChromaListe.Web.Pipelines;

internal sealed class GenerateSass : Pipeline
{
    public GenerateSass()
    {
        Isolated = true;

        InputModules =
        [
            new ReadFiles("assets/css/master.scss")
        ];

        ProcessModules =
        [
            new CompileSass().WithCompressedOutputStyle()
        ];

        OutputModules =
        [
            new WriteFiles()
        ];
    }
}
