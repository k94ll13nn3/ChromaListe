using System.Globalization;
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
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.CreateSpecificCulture("fr-FR");
            return await Bootstrapper
                .Factory
                .CreateDefault(args)
                .ConfigureSettings(c =>
                {
                    c[CustomKeys.SiteTitle] = "ChromaListe by Keuvain";
                    c[Keys.Host] = "k94ll13nn3.github.io";
                    c[Keys.LinkRoot] = "/ChromaListe";
                })
                .RunAsync();
        }
    }
}
