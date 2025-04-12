using System.Collections.Generic;
using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.ItemGroups
{
    public class GreenDevilledEgg : GenericStackableItemGroup
    {
        public override string UniqueNameID => "GreenDevilledEgg";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("GreenDevilledEgg").AssignMaterialsByNames();
        public override bool IsMergeableSide => true;

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.GreenDeYolkedSlicedEgg,
                    GDOReferences.MixedEggYolk
                },
                Min = 2,
                Max = 2
            }
        };
    }
}