namespace ChromaListe.Web.Core;

public enum GameVersion
{
    [ChromaDescription("Cristal (VC)", "Cristal\n(VC)")]
    CVC = 0,

    [ChromaDescription("X")]
    X = 1,

    [ChromaDescription("Rubis Oméga", "Rubis\nOméga")]
    OR = 2,

    [ChromaDescription("Saphir Alpha", "Saphir\nAlpha")]
    AS = 3,

    [ChromaDescription("Lune")]
    MO = 4,

    [ChromaDescription("Ultra-Soleil")]
    US = 5,

    [ChromaDescription("Épée")]
    SW = 6,

    [ChromaDescription("Or HeartGold", "Or\nHeartGold")]
    HG = 7,

    [ChromaDescription("Diamant Étincelant", "Diamant\nÉtincelant")]
    BD = 8,

    [ChromaDescription("Légendes Pokémon : Arceus", "Légendes\nPokémon :\nArceus")]
    PLA = 9,

    [ChromaDescription("Écarlate")]
    SC = 10,

    [ChromaDescription("Violet")]
    VI = 11,
}
