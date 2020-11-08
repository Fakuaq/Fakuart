using IL.Terraria.UI;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fakuart.Items
{
    public class ManaBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mana Bow");
            Tooltip.SetDefault("Tu jau zin");
        }

        public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (player.statMana > 4)
            {
                item.mana = 5;
                type = ProjectileID.JestersArrow;
            } else
            {
                item.mana = 0;
                type = ProjectileID.WoodenArrowFriendly;
            }

            return true; 
        }

        public override void SetDefaults()
        {
            item.damage = 22;
            item.ranged = true;
            item.width = 12;
            item.height = 38;
            item.maxStack = 1;
            item.useTime = 28;
            item.useAnimation = 28;
            item.useStyle = 5;
            item.knockBack = 2;
            item.value = 12000;
            item.rare = 2;
            item.UseSound = SoundID.Item5;
            item.noMelee = true;
            item.shoot = 1;
            item.useAmmo = AmmoID.Arrow;
            item.shootSpeed = 9f;
            item.autoReuse = false;
           
            // Set other item.X values here
            

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
            // Recipes here. See Basic Recipe Guide
        }
    }
}