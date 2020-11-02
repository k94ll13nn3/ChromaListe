using System.ComponentModel;

namespace ChromaListe.Web.Core
{
    public enum GameVersion
    {
        [Description("Cristal (console virtuelle)")]
        CVC,

        [Description("X")]
        X,

        [Description("Rubis Oméga")]
        OR,

        [Description("Saphir Alpha")]
        AS,

        [Description("Lune")]
        MO,

        [Description("Ultra-Soleil")]
        US,

        [Description("Épée")]
        SW,

        [Description("Or HeartGold")]
        HG,
    }
}
