using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Threading.Tasks;
using ChromaListe.Web.Core;
using Statiq.App;
using Statiq.Common;

namespace ChromaListe.Web
{
    public static class Program
    {
        [SuppressMessage("Style", "IDE1006", Justification = "Name cannot be changed.")]
        private static async Task<int> Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.CreateSpecificCulture("fr-FR");
            return await Bootstrapper
                .Factory
                .CreateDefault(args)
                .ConfigureSettings(c =>
                {
                    c[CustomKeys.SiteTitle] = "Keuvain's shiny living dex";
                    c[Keys.Host] = "k94ll13nn3.github.io";
                    c[Keys.LinkRoot] = "/ChromaListe";
                })
                .RunAsync();
        }
    }
}
