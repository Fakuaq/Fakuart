using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;
using Fakuart.Projectiles;

namespace Fakuart.Items
{
	public class LightSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Spawn a light projectile when swinging");
		}

		public override void SetDefaults()
		{
			item.damage = 16;
			item.melee = true;
			item.width = 36;
			item.height = 36;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 3;
			item.value = Item.sellPrice(gold: 3);
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.crit = 8; // 4% by default
			item.shootSpeed = 8f;
			item.shoot = ModContent.ProjectileType<LightProjectile>();
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			Vector2 projSpeed = new Vector2(0, 0);
			Vector2 posOffset = new Vector2(0, -150);	
			Projectile.NewProjectile(player.position + posOffset, projSpeed, ProjectileType<LightProjectile>(), item.damage - 8, 1f, player.whoAmI);
			return false;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LightsBane, 1);
			recipe.AddIngredient(ItemID.ShadowOrb, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}