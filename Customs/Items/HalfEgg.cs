using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class HalfEgg : GenericStackableItem
    {
        public override string UniqueNameID => "HalfEgg";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("HalfEgg").AssignMaterialsByNames();
    }
}