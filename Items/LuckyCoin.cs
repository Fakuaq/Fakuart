using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fakuart.Items
{
    public class LuckyCoin : ModItem
    {
        public override void SetStaticDefaults()
        {
           DisplayName.SetDefault("Lucky coin");
        }
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.rare = ItemRarityID.Yellow;
            item.value = Item.sellPrice(gold: 10);
            item.holdStyle = 1;
            //item.useAnimation = 10;
        }
        public override void HoldItem(Player player)
        {
            player.noFallDmg = true; 
        }
        public override bool OnPickup(Player player)
        {
            Main.PlaySound(SoundID.Coins, -1, -1, 1); // coin pickup sound
            return true;
        }
    }
}
