using Microsoft.Xna.Framework;
using Mono.Cecil;
using Terraria;
using Terraria.ModLoader;

namespace Fakuart.Buffs
{
    public class SlownessBuff : ModBuff
    {
        bool slow = false;
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Slowness");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
            
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            if (!slow) 
            {
                npc.velocity.X *= 0.75f;
                slow = true;
            }
            else
            {
                slow = false;
            }
        }
    }
}