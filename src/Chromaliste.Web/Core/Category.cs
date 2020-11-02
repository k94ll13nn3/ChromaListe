using System.ComponentModel;

namespace ChromaListe.Web.Core
{
    public enum Category
    {
        [Description("Appels à l'aide")]
        Sos,

        [Description("Expéditions Dynamax")]
        DynamaxAdventures,

        [Description("Horde")]
        Horde,

        [Description("Masuda")]
        Masuda,

        [Description("Navi-Dex")]
        DexNav,

        [Description("Pêche à la chaîne")]
        ChainFishing,

        [Description("Rencontre aléatoire")]
        RandomEncounter,

        [Description("Rencontre visible")]
        VisibleEncounter,

        [Description("Reset")]
        Reset,

        [Description("RNG")]
        Rng,

        [Description("Safari des Amis")]
        FriendSafari,
    }
}
