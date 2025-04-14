using Easter2025.Customs.Generics;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class WrappedCremeEgg : GenericStackableItem
    {
        public override string UniqueNameID => "WrappedCremeEgg";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("WrappedCremeEgg").AssignMaterialsByNames();
    }
}