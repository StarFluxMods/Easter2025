using Easter2025.Customs.Generics;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class GreenDeYolkedSlicedEgg : GenericStackableItem
    {
        public override string UniqueNameID => "GreenDeYolkedSlicedEgg";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("GreenDeYolkedSlicedEgg").AssignMaterialsByNames();
    }
}