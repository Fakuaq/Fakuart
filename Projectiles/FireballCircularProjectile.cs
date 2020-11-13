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
    public class FireballCircularProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.Fireball);
            projectile.damage = 5;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.penetrate = 1;
            projectile.timeLeft = 120; // 2 secs
            projectile.alpha = 255;
            
        }

        public override void AI()
        {
            projectile.velocity.X = 0;
            projectile.velocity.Y = 4;
        }
        public override bool OnTileCollide(Vector2 oldVelocity) // used to remove the tile collide sound that is cloned
        {
            projectile.Kill();
            return false;
        }
        public override void OnHitNPC(NPC target, int damage, float knockBack, bool crit) => target.AddBuff(BuffID.OnFire, 30);
    }
}