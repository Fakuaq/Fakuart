using Fakuart.Projectiles;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Fakuart.Buffs;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace Fakuart.Projectiles
{
	public class MedievalStaffProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Medieval Arrow");
			// Sets the amount of frames this minion has on its spritesheet
			Main.projFrames[projectile.type] = 1;
			// This is necessary for right-click targeting
			ProjectileID.Sets.MinionTargettingFeature[projectile.type] = true;

			// These below are needed for a minion
			// Denotes that this projectile is a pet or minion
			Main.projPet[projectile.type] = true;
			// This is needed so your minion can properly spawn when summoned and replaced when other minions are summoned
			ProjectileID.Sets.MinionSacrificable[projectile.type] = true;
			// Don't mistake this with "if this is true, then it will automatically home". It is just for damage reduction for certain NPCs
			ProjectileID.Sets.Homing[projectile.type] = true;
		}

		public sealed override void SetDefaults()
		{
			projectile.width = 18;
			projectile.height = 28;
			// Makes the minion go through tiles freely
			projectile.tileCollide = false;

			// These below are needed for a minion weapon
			// Only controls if it deals damage to enemies on contact (more on that later)
			projectile.friendly = true;
			// Only determines the damage type
			projectile.minion = true;
			// Amount of slots this minion occupies from the total minion slots available to the player (more on that later)
			// Needed so the minion doesn't despawn on collision with enemies or tiles
			projectile.penetrate = -1;
			projectile.CloneDefaults(ProjectileID.Spazmamini);
			aiType = ProjectileID.Spazmamini;
			projectile.minionSlots = 1f;
		}

		// Here you can decide if your minion breaks things like grass or pots
		public override bool? CanCutTiles()
		{
			return false;
		}

		// This is mandatory if your minion deals contact damage (further related stuff in AI() in the Movement region)
		public override bool MinionContactDamage()
		{
			return true;
		}

		public override void AI()
		{
			Player player = Main.player[projectile.owner];

			#region Active check
			// This is the "active check", makes sure the minion is alive while the player is alive, and despawns if not
			if (player.dead || !player.active)
			{
				player.ClearBuff(ModContent.BuffType<MedievalArrow>());
			}
			if (player.HasBuff(ModContent.BuffType<MedievalArrow>()))
			{
				projectile.timeLeft = 2;
			}
			#endregion
		}


		}
	}