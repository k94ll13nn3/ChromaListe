using System.Globalization;
using ChromaListe.Web;
using ChromaListe.Web.Core;

if (args.Length > 0 && args[0] is "new")
{
    await PostGenerator.RunAsync();
    return;
}

CultureInfo.DefaultThreadCurrentCulture = CultureInfo.CreateSpecificCulture("fr-FR");

await Bootstrapper
    .Factory
    .CreateDefault(args)
    .ConfigureSettings(c =>
    {
        c[CustomKeys.SiteTitle] = "Shiny Dex";
        c[Keys.Host] = "k94ll13nn3.github.io";
        c[Keys.LinkRoot] = "/ChromaListe";
    })
    .RunAsync();
