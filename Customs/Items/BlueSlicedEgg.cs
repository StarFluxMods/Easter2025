using System.Collections.Generic;
using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class BlueSlicedEgg : GenericStackableItem
    {
        public override string UniqueNameID => "BlueSlicedEgg";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("BlueSlicedEgg").AssignMaterialsByNames();
        public override int SplitCount => 1;
        public override Item SplitSubItem => GDOReferences.EggYolk;
        public override List<Item> SplitDepletedItems => new List<Item> { GDOReferences.BlueDeYolkedSlicedEgg };
    }
}