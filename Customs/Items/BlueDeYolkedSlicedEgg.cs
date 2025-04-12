using Easter2025.Customs.Generics;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class BlueDeYolkedSlicedEgg : GenericStackableItem
    {
        public override string UniqueNameID => "BlueDeYolkedSlicedEgg";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("BlueDeYolkedSlicedEgg").AssignMaterialsByNames();
    }
}