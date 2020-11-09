using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using static Terraria.ModLoader.ModContent;

namespace Fakuart.Projectiles
{
	public class WoodenArrowClone : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("WoodenArrowClone");
		}

		public override void SetDefaults()
		{
			projectile.arrow = true;
			projectile.damage = 6;
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.ranged = true;
			aiType = ProjectileID.WoodenArrowFriendly;
		}


		// Additional hooks/methods here.
	}
}