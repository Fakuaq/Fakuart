using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;
using Fakuart.Buffs;

namespace Fakuart.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class PyramidHelmet : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Yellow;
			item.defense = 2;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<PyramidBreastplate>() && legs.type == ModContent.ItemType<PyramidLeggings>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Grants Pyramid's Blessing buff";
			player.AddBuff(ModContent.BuffType<PyramidsBlessing>(), 1);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Sandstone, 20);
			recipe.AddIngredient(ItemID.IronBar, 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}