using Fakuart.Projectiles;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Fakuart.Buffs;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;
using Fakuart.Items.Armor;

namespace Fakuart.Items
{
	public class MedievalStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Medieval King's Staff");
			Tooltip.SetDefault("Summons a medieval arrow to fight for you");
			ItemID.Sets.GamepadWholeScreenUseRange[item.type] = true; // This lets the player target anywhere on the whole screen while using a controller.
			ItemID.Sets.LockOnIgnoresCollision[item.type] = true;
		}

		public override void ModifyWeaponDamage(Player player, ref float add, ref float mult)
		{
			if (player.armor[0].type == ModContent.ItemType<HelmetOfTheFallen>())
			{
				mult *= 1.2f;
			}
			if (player.armor[2].type == ModContent.ItemType<BardsBoots>())
			{
				mult *= 1.1f;
			}
		}

		public override void SetDefaults()
		{
			item.damage = 6;
			item.knockBack = 3f;
			item.mana = 10;
			item.width = 32;
			item.height = 32;
			item.useTime = 36;
			item.useAnimation = 36;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.rare = ItemRarityID.Cyan;
			item.UseSound = SoundID.Item44;

			// These below are needed for a minion weapon
			item.noMelee = true;
			item.summon = true;
			item.buffType = ModContent.BuffType<MedievalArrow>();
			// No buffTime because otherwise the item tooltip would say something like "1 minute duration"
			item.shoot = ModContent.ProjectileType<MedievalStaffProjectile>();
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// This is needed so the buff that keeps your minion alive and allows you to despawn it properly applies
			player.AddBuff(item.buffType, 2);

			// Here you can change where the minion is spawned. Most vanilla minions spawn at the cursor position.
			position = Main.MouseWorld;
			return true;
		}
	}
}