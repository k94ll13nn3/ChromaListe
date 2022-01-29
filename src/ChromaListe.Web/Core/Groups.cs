namespace ChromaListe.Web.Core;

[Flags]
public enum Groups
{
    None = 0,
    [ChromaDescription("Génération 1")]
    Generation1 = 1,
    [ChromaDescription("Génération 2")]
    Generation2 = 1 << 1,
    [ChromaDescription("Génération 3")]
    Generation3 = 1 << 2,
    [ChromaDescription("Génération 4")]
    Generation4 = 1 << 3,
    [ChromaDescription("Génération 5")]
    Generation5 = 1 << 4,
    [ChromaDescription("Génération 6")]
    Generation6 = 1 << 5,
    [ChromaDescription("Génération 7")]
    Generation7 = 1 << 6,
    [ChromaDescription("Génération 8")]
    Generation8 = 1 << 7,
    [ChromaDescription("Formes d'Alola")]
    Alola = 1 << 8,
    [ChromaDescription("Formes de Galar")]
    Galar = 1 << 9,
    [ChromaDescription("Pokémon de départ")]
    Starter = 1 << 10,
    [ChromaDescription("Pokémon légendaires")]
    RestrictedLegendary = 1 << 11,
    [ChromaDescription("Pokémon fabuleux")]
    Mythical = 1 << 12,
    [ChromaDescription("Pokémon fossiles")]
    Fossil = 1 << 13,
    [ChromaDescription("Pokémon Pikachu-like")]
    Pikalike = 1 << 14,
    [ChromaDescription("Ultra-Chimères")]
    UltraBeast = 1 << 15,
    [ChromaDescription("Famille d'Évoli")]
    Eevee = 1 << 16,
    [ChromaDescription("Pokémon Regi")]
    Regi = 1 << 17,
    [ChromaDescription("Pokémon semi-légendaires")]
    SubLegendary = 1 << 18,
    [ChromaDescription("Formes de Hisui")]
    Hisui = 1 << 19,
}
