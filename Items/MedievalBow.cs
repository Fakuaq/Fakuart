using IL.Terraria.UI;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;
using Fakuart.Projectiles;

namespace Fakuart.Items
{
    public class MedievalBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Medieval Bow");
            Tooltip.SetDefault("40% chance not to consume ammo \n Shoots twice");
        }

        public override void SetDefaults()
        {
            item.damage = 10;
            item.ranged = true;
            item.width = 12;
            item.height = 38;
            item.maxStack = 1;
            item.useAnimation = 25;
            item.useStyle = 5;
            item.knockBack = 2;
            item.value = 12000;
            item.rare = 2;
            item.useAnimation = 14;
            item.useTime = 7;
            item.reuseDelay = 30;
            item.UseSound = SoundID.Item5;
            item.noMelee = true;
            item.shoot = mod.ProjectileType("WoodenArrowClone");
            item.useAmmo = AmmoID.Arrow;
            item.shootSpeed = 8f;
            item.autoReuse = false;
        }

        public override bool ConsumeAmmo(Player player)
        {
            return Main.rand.NextFloat() >= .40f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoldBar, 8);
            recipe.AddIngredient(ItemID.IronBar, 8);
            recipe.AddIngredient(ItemID.Emerald, 2);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}