using Easter2025.Customs.Generics;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class RedDeYolkedSlicedEgg : GenericStackableItem
    {
        public override string UniqueNameID => "RedDeYolkedSlicedEgg";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("RedDeYolkedSlicedEgg").AssignMaterialsByNames();
    }
}