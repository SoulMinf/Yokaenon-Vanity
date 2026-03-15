using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace Yokaenon
{
    public class Config : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [LabelKey("$Mods.Yokaenon.DisableDyes.Label")]
        [TooltipKey("$Mods.Yokaenon.DisableDyes.Tooltip")]
        [DefaultValue(true)]
        public bool DisableDyes { get; set; }
    }
}