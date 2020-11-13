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
    public class FireballProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.Fireball);
            aiType = ProjectileID.Fireball;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.penetrate = 2;
            projectile.timeLeft = 120; // 2secs
            projectile.alpha = 255;
        }
        public override void OnHitNPC(NPC target, int damage, float knockBack, bool crit) => target.AddBuff(BuffID.OnFire, 90);
    }
}