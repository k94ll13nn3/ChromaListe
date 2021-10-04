using System.ComponentModel;

namespace ChromaListe.Web.Core;

public enum Category
{
    [Description("Appels à l'aide")]
    Sos = 0,

    [Description("Expéditions Dynamax")]
    DynamaxAdventures = 1,

    [Description("Horde")]
    Horde = 2,

    [Description("Masuda")]
    Masuda = 3,

    [Description("Navi-Dex")]
    DexNav = 4,

    [Description("Pêche à la chaîne")]
    ChainFishing = 5,

    [Description("Rencontre aléatoire")]
    RandomEncounter = 6,

    [Description("Rencontre visible")]
    VisibleEncounter = 7,

    [Description("Reset")]
    Reset = 8,

    [Description("RNG")]
    Rng = 9,

    [Description("Safari des Amis")]
    FriendSafari = 10,
}
