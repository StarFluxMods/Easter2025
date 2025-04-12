using Easter2025.Customs.Generics;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class DeYolkedSlicedEgg : GenericStackableItem
    {
        public override string UniqueNameID => "DeYolkedSlicedEgg";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("DeYolkedSlicedEgg").AssignMaterialsByNames();
    }
}