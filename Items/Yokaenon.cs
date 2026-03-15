using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Yokaenon.Items
{
    public class Yokaenon : ModItem
    {
        public override void Load()
        {
            if (Main.netMode != NetmodeID.Server)
            {
                EquipLoader.AddEquipTexture(Mod, "Yokaenon/Items/Yokaenon_Head", EquipType.Head, this);
                EquipLoader.AddEquipTexture(Mod, "Yokaenon/Items/Yokaenon_Body", EquipType.Body, this);
                EquipLoader.AddEquipTexture(Mod, "Yokaenon/Items/Yokaenon_Legs", EquipType.Legs, this);
                EquipLoader.AddEquipTexture(Mod, "Yokaenon/Items/Yokaenon_Back", EquipType.Back, this);
            }
        }

        public override void SetStaticDefaults()
        {
            if (Main.netMode != NetmodeID.Server)
            {
                int head = EquipLoader.GetEquipSlot(Mod, Name, EquipType.Head);
                ArmorIDs.Head.Sets.DrawHead[head] = false;

                int body = EquipLoader.GetEquipSlot(Mod, Name, EquipType.Body);
                ArmorIDs.Body.Sets.HidesTopSkin[body] = true;
                ArmorIDs.Body.Sets.HidesArms[body] = true;

                int legs = EquipLoader.GetEquipSlot(Mod, Name, EquipType.Legs);
                ArmorIDs.Legs.Sets.HidesBottomSkin[legs] = true;

                int back = EquipLoader.GetEquipSlot(Mod, Name, EquipType.Back);
                ArmorIDs.Back.Sets.DrawInTailLayer[back] = true;
            }
        }

        public override void SetDefaults()
        {
            Item.width = 34;
            Item.height = 20;
            Item.accessory = true;
            Item.value = Item.buyPrice(0, 0, 0, 0);
            Item.vanity = true;
        }

        public override void UpdateVanity(Player player)
        {
            player.GetModPlayer<YokaenonPlayer>().vanityEquipped = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            bool flag = !hideVisual;
            if (flag)
            {
                player.GetModPlayer<YokaenonPlayer>().vanityEquipped = true;
            }
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Silk, 20)
                .Register();
        }
    }
}