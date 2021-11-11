namespace ChromaListe.Web.Core;

public enum Category
{
    [ChromaDescription("Appels à l'aide", "Appels\naide")]
    Sos = 0,

    [ChromaDescription("Expéditions Dynamax", "Expé.\nDyna.")]
    DynamaxAdventures = 1,

    [ChromaDescription("Horde")]
    Horde = 2,

    [ChromaDescription("Masuda")]
    Masuda = 3,

    [ChromaDescription("Navi-Dex")]
    DexNav = 4,

    [ChromaDescription("Pêche à la chaîne", "Pêche\nchaîne")]
    ChainFishing = 5,

    [ChromaDescription("Rencontre aléatoire", "Renc.\naléa.")]
    RandomEncounter = 6,

    [ChromaDescription("Rencontre visible", "Renc.\nvis.")]
    VisibleEncounter = 7,

    [ChromaDescription("Reset")]
    Reset = 8,

    [ChromaDescription("RNG")]
    Rng = 9,

    [ChromaDescription("Safari des Amis", "Safari\nAmis")]
    FriendSafari = 10,
}
