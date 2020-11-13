using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fakuart.Items
{
    public class LuckyShell : ModItem
    {
        public override void SetStaticDefaults()
        {
           DisplayName.SetDefault("Lucky Shell");
        }
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.rare = ItemRarityID.Yellow;
            item.value = Item.sellPrice(gold: 10);
            item.holdStyle = 1;
        }
        public override void HoldItem(Player player)
        {
            player.noFallDmg = true;
        }
    }
}
