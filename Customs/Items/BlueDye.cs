using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class BlueDye : GenericStackableItem
    {
        public override string UniqueNameID => "BlueDye";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("BlueDye").AssignMaterialsByNames();
        public override Appliance DedicatedProvider => GDOReferences.DyeProvider;
        public override string ColourBlindTag => "B";
    }
}