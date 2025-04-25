using System.Collections.Generic;
using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class WrapperRoll : GenericStackableItem
    {
        public override string UniqueNameID => "WrapperRoll";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("WrapperRoll").AssignMaterialsByNames();
        public override int SplitCount => 999;
        public override bool AllowSplitMerging => true;
        public override bool PreventExplicitSplit => true;
        public override Item SplitSubItem => GDOReferences.Wrapper;
        public override Appliance DedicatedProvider => GDOReferences.WrapperProvider;
    }
}