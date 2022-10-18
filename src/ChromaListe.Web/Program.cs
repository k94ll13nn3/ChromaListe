using System.Globalization;
using ChromaListe.Web.Core;

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
