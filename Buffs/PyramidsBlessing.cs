using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace Fakuart.Buffs
{
    public class PyramidsBlessing : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Pyramid's Blessing");
            Description.SetDefault("Increases mining speed by 15%");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false; 
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.pickSpeed = player.pickSpeed*0.85f; 
        }
    }
}