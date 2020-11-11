using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;
using Fakuart.Projectiles;

namespace Fakuart.Items
{
	public class JungleStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Jungle Staff");
			Item.staff[item.type] = true;				// By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}
		
		public override void SetDefaults()
		{
			item.damage = 22;
			item.mana = 8;
			item.magic = true;
			item.noMelee = true;
			item.autoReuse = false;
			item.width = 40;
			item.height = 40;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.shoot = ProjectileID.HornetStinger;
			item.shootSpeed = 8f;
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RichMahogany, 20);
            recipe.AddIngredient(ItemID.Topaz, 3);
            recipe.AddIngredient(ItemID.Vine, 1);
			recipe.AddIngredient(ItemID.Stinger, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}