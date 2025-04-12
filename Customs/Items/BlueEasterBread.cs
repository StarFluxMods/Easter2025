using Easter2025.Customs.Generics;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class BlueEasterBread : GenericStackableItem
    {
        public override string UniqueNameID => "BlueEasterBread";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("BlueEasterBread").AssignMaterialsByNames();
    }
}