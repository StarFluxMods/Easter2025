using Easter2025.Customs.Generics;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class RedShell : GenericStackableItem
    {
        public override string UniqueNameID => "RedShell";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("RedShell").AssignMaterialsByNames();
    }
}