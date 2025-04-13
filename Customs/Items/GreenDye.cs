using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class GreenDye : GenericStackableItem
    {
        public override string UniqueNameID => "GreenDye";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("GreenDye").AssignMaterialsByNames();
        public override Appliance DedicatedProvider => GDOReferences.DyeProvider;
        public override string ColourBlindTag => "G";

        public override void OnRegister(Item gameDataObject)
        {
            base.OnRegister(gameDataObject);
            gameDataObject.Prefab.AddComponent<ColourBlindMode>().Element = gameDataObject.Prefab.GetChild("Square");
        }
    }
}