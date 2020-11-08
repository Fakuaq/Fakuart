using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Fakuart.Buffs;
using static Terraria.ModLoader.ModContent;


namespace Fakuart.Items
{
	public class SpeedSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("TutorialSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Speedboost");
		}
		 public override void HoldItem(Player player)
		{
            
			if (player.statMana > 1)
			{
				player.AddBuff(ModContent.BuffType<SpeedBuffons>(), 1);
                player.statMana -= 1;
            } else
            {
				player.statMana = 0;
            }


		} 
		public override void SetDefaults() 
		{
			item.damage = 111;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}