using Terraria;
using Terraria.ModLoader;
using Fakuart.Projectiles;

namespace Fakuart.Buffs
{
	public class MedievalArrow : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Medieval Arrow");
			Description.SetDefault("The medieval arrow will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			if (player.ownedProjectileCounts[ModContent.ProjectileType<MedievalStaffProjectile>()] > 0)
			{
				player.buffTime[buffIndex] = 18000;
			}
			else
			{
				player.DelBuff(buffIndex);
				buffIndex--;
			}
		}
	}
}