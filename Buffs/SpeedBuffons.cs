using Terraria;
using Terraria.ModLoader;

namespace Fakuart.Buffs
{
    public class SpeedBuffons : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Blue shrek");
            Description.SetDefault("Blue shrek gives you big fat speed blessing (30%)");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false; 
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.moveSpeed = player.moveSpeed*1.3f; 
        }
    }
}