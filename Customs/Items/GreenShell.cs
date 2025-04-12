using Easter2025.Customs.Generics;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class GreenShell : GenericStackableItem
    {
        public override string UniqueNameID => "GreenShell";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("GreenShell").AssignMaterialsByNames();
    }
}