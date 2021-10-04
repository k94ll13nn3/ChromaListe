using System.ComponentModel;

namespace ChromaListe.Web.Core;

public enum GameVersion
{
    [Description("Cristal (VC)")]
    CVC = 0,

    [Description("X")]
    X = 1,

    [Description("Rubis Oméga")]
    OR = 2,

    [Description("Saphir Alpha")]
    AS = 3,

    [Description("Lune")]
    MO = 4,

    [Description("Ultra-Soleil")]
    US = 5,

    [Description("Épée")]
    SW = 6,

    [Description("Or HeartGold")]
    HG = 7,
}
