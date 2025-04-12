using Easter2025.Customs.Generics;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class BlueShell : GenericStackableItem
    {
        public override string UniqueNameID => "BlueShell";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("BlueShell").AssignMaterialsByNames();
    }
}