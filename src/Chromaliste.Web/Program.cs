using System.Threading.Tasks;
using Chromaliste.Web.Core;
using Statiq.App;
using Statiq.Common;

namespace Chromaliste.Web
{
    public static class Program
    {
        private static async Task<int> Main(string[] args)
        {
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