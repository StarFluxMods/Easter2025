using System.Collections.Generic;
using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.ItemGroups
{
    public class DevilledEgg : GenericStackableItemGroup
    {
        public override string UniqueNameID => "DevilledEgg";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("DevilledEgg").AssignMaterialsByNames();
        public override bool IsMergeableSide => true;

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.DeYolkedSlicedEgg,
                    GDOReferences.MixedEggYolk
                },
                Min = 2,
                Max = 2
            }
        };

        public override List<Item> SatisfiedBy => new List<Item>
        {
            GDOReferences.DevilledEgg,
            GDOReferences.RedDevilledEgg,
            GDOReferences.GreenDevilledEgg,
            GDOReferences.BlueDevilledEgg,
        };
    }
}