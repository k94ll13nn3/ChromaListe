using System.ComponentModel;

namespace ChromaListe.Web.Core;

[Flags]
public enum Groups
{
    None = 0,
    [Description("Génération 1")]
    Generation1 = 1,
    [Description("Génération 2")]
    Generation2 = 1 << 1,
    [Description("Génération 3")]
    Generation3 = 1 << 2,
    [Description("Génération 4")]
    Generation4 = 1 << 3,
    [Description("Génération 5")]
    Generation5 = 1 << 4,
    [Description("Génération 6")]
    Generation6 = 1 << 5,
    [Description("Génération 7")]
    Generation7 = 1 << 6,
    [Description("Génération 8")]
    Generation8 = 1 << 7,
    [Description("Formes d'Alola")]
    Alola = 1 << 8,
    [Description("Formes de Galar")]
    Galar = 1 << 9,
    [Description("Pokémon de départ")]
    Starter = 1 << 10,
    [Description("Pokémon légendaires")]
    RestrictedLegendary = 1 << 11,
    [Description("Pokémon fabuleux")]
    Mythical = 1 << 12,
    [Description("Pokémon fossiles")]
    Fossil = 1 << 13,
    [Description("Pokémon Pikachu-like")]
    Pikalike = 1 << 14,
    [Description("Ultra-Chimères")]
    UltraBeast = 1 << 15,
    [Description("Famille d'Évoli")]
    Eevee = 1 << 16,
    [Description("Pokémon Regi")]
    Regi = 1 << 17,
    [Description("Pokémon semi-légendaires")]
    SubLegendary = 1 << 18,
}
