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
    public class IcyStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Icy staff");
            Item.staff[item.type] = true;
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.SapphireStaff);
            item.damage = 14;
            item.magic = true;
            item.mana = 12;
            item.width = 16;
            item.height = 16;
            item.useTime = 25;  
            item.useAnimation = 25;
            item.rare = ItemRarityID.Green;
            item.value = Item.sellPrice(gold: 2);
            item.noMelee = true;
            item.knockBack = 1;
            item.shoot = ProjectileType<IceProjectile>();
            item.shootSpeed = 12f;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.autoReuse = false;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 speed = new Vector2(speedX, speedY);
            Vector2 positionOffset = new Vector2(Main.rand.Next(-125, 125), Main.rand.Next(-75, 0));
            Vector2 newPosition = Vector2.Add(position, positionOffset);
            Projectile.NewProjectile(newPosition, speed, type, item.damage, knockBack, player.whoAmI);
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LeadBar, 10);
            recipe.AddIngredient(ItemID.Sapphire, 3);
            recipe.AddIngredient(ItemID.IceBlock, 50);
            recipe.AddIngredient(ItemID.BorealWood, 25);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
