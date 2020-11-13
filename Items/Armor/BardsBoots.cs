using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace Fakuart.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class BardsBoots : ModItem
	{
		public override void SetStaticDefaults()
		{
			 DisplayName.SetDefault("Bard's Boots"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Increases movement speed by 5% \nIncreases the damage of all medieval items by 10%");
		}
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Yellow;
			item.defense = 1;
		}

        public override void UpdateEquip(Player player)
        {
			player.moveSpeed *= 1.05f;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Leather, 6);
            recipe.AddIngredient(ItemID.Feather, 2);
			recipe.AddIngredient(ItemID.SwiftnessPotion, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}