using System.Globalization;
using ChromaListe.Web.Core;

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
