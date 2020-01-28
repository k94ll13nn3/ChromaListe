using System.Threading.Tasks;
using ChromaListe.Web.Core;
using Statiq.App;
using Statiq.Common;

namespace ChromaListe.Web
{
    public static class Program
    {
        private static async Task<int> Main(string[] args)
        {
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("fr-FR");
            return await Bootstrapper
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
