using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.PlayerCosmetics
{
    public class BunnyTail : CustomPlayerCosmetic
    {
        public override string UniqueNameID => "BunnyTail";
        public override CosmeticType CosmeticType => CosmeticType.Outfit;
        public override GameObject Visual => Mod.Bundle.LoadAsset<GameObject>("BunnyTail").AssignMaterialsByNames();
        public override bool BlockHats => false;

        public override void OnRegister(PlayerCosmetic gameDataObject)
        {
            PlayerOutfitComponent playerOutfitComponent = gameDataObject.Visual.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(gameDataObject.Visual, "Icosphere").GetComponent<SkinnedMeshRenderer>());
        }
    }
}