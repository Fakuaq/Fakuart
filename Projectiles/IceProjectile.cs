using System; 
using Fakuart.Buffs;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Steamworks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fakuart.Projectiles 
{
    public class IceProjectile : ModProjectile 
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.SapphireBolt);
            aiType = ProjectileID.SapphireBolt;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            if(!target.HasBuff(ModContent.BuffType<SlownessBuff>())) { // so you cant perma slow
                target.AddBuff(ModContent.BuffType<SlownessBuff>(), 60); // 1 sec
            }
        }
    }
}