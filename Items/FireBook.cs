using IL.Terraria.UI;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;
using Fakuart.Projectiles;
using Steamworks;

namespace Fakuart.Items
{
    public class FireBook : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fire Book");
            Item.staff[item.type] = true;
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.WaterBolt);
            item.damage = 14;
            item.magic = true;
            item.useTime = 25;
            item.useAnimation = 25;
            item.rare = ItemRarityID.Green;
            item.value = Item.sellPrice(gold: 2);
            item.noMelee = true;
            item.knockBack = 3;
            item.shoot = ProjectileType<FireballProjectile>();
            item.shootSpeed = 12f;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.UseSound = SoundID.DD2_BetsyFireballShot;
            
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

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 newPos = new Vector2(Main.mouseX + Main.screenPosition.X, player.position.Y - 75);
            if(player.position.X - newPos.X > 300 || player.position.X - newPos.X < -300)
            {
                newPos.X = player.position.X + (300 * player.direction);
            }
            newPos.X -= 50; // so cursor is in middle of the 3 shots 
            for (int i = 0; i < 3; i++)
            {
                newPos.X += 25;
                Projectile.NewProjectile(newPos, new Vector2(speedX, speedY), ProjectileType<FireballCircularProjectile>(), damage, knockBack, player.whoAmI);
            }
            return true;
        }
        
    }
}
    