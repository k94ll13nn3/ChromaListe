using Statiq.Sass;

namespace ChromaListe.Web.Pipelines;

public class GenerateSass : Pipeline
{
    public GenerateSass()
    {
        Isolated = true;

        InputModules = new ModuleList
            {
                new ReadFiles("assets/css/master.scss")
            };

        ProcessModules = new ModuleList
            {
                new CompileSass().WithCompressedOutputStyle()
            };

        OutputModules = new ModuleList
            {
                new WriteFiles()
            };
    }
}
