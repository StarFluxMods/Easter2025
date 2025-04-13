using Easter2025.Customs.Generics;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class EggMould : GenericStackableItem
    {
        public override string UniqueNameID => "EggMould";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("EggMould").AssignMaterialsByNames();
        public override bool IsIndisposable => true;
    }
}