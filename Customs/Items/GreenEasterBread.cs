using Easter2025.Customs.Generics;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class GreenEasterBread : GenericStackableItem
    {
        public override string UniqueNameID => "GreenEasterBread";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("GreenEasterBread").AssignMaterialsByNames();
    }
}