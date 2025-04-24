using Easter2025.Customs.Generics;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class RedEasterBread : GenericStackableItem
    {
        public override string UniqueNameID => "RedEasterBread";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("RedEasterBread").AssignMaterialsByNames();
        public override ItemValue ItemValue => ItemValue.Small;
    }
}