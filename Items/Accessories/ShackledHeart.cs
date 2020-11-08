
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using static Terraria.ModLoader.ModContent;

namespace Fakuart.Items.Accessories
{
	public class ShackledHeart : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("2 defense\nIncreases life by 30");
		}

		public override void SetDefaults()
		{
			item.accessory = true;
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Shackle, 1);
			recipe.AddIngredient(ItemID.LifeCrystal, 2);
			recipe.AddIngredient(ItemID.Chain, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.statDefense += 2;
			player.statLifeMax2 += 30;
        }
    }
}