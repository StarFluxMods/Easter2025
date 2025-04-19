using System.Collections.Generic;
using System.Reflection;
using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class CookedCremeFillingPot : CustomItem
    {
        public override string UniqueNameID => "CookedCremeFillingPot";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CookedCremeFillingPot").AssignMaterialsByNames();
        public override Item DisposesTo => GDOReferences.Pot;
        public override Item SplitSubItem => GDOReferences.CremeFilling;
        public override bool PreventExplicitSplit => true;
        public override bool AllowSplitMerging => true;
        public override List<Item> SplitDepletedItems => new List<Item> { GDOReferences.Pot};
        public override int SplitCount => 10;
    }
}