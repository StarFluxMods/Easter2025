using Easter2025.Customs.Generics;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class EggYolk : GenericStackableItem
    {
        public override string UniqueNameID => "EggYolk";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("EggYolk").AssignMaterialsByNames();
    }
}