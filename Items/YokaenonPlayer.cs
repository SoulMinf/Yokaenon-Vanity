using Terraria;
using Terraria.ModLoader;

namespace Yokaenon.Items
{
    public class YokaenonPlayer : ModPlayer
    {
        public bool vanityEquipped;

        public override void ResetEffects()
        {
            vanityEquipped = false;
        }

        public override void FrameEffects()
        {
            if (vanityEquipped)
            {
                int head = EquipLoader.GetEquipSlot(Mod, "Yokaenon", EquipType.Head);
                int body = EquipLoader.GetEquipSlot(Mod, "Yokaenon", EquipType.Body);
                int legs = EquipLoader.GetEquipSlot(Mod, "Yokaenon", EquipType.Legs);
                int back = EquipLoader.GetEquipSlot(Mod, "Yokaenon", EquipType.Back);

                Player.head = head;
                Player.body = body;
                Player.legs = legs;
                Player.back = back;

                if (ModContent.GetInstance<Config>().DisableDyes)
                {
                    Player.cHead = 0;
                    Player.cBody = 0;
                    Player.cLegs = 0;
                    Player.cBack = 0;
                }
            }
        }
    }
}