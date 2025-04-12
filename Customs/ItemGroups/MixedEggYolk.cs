using System.Collections.Generic;
using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.ItemGroups
{
    public class MixedEggYolk : GenericStackableItemGroup
    {
        public override string UniqueNameID => "MixedEggYolk";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("MixedEggYolk").AssignMaterialsByNames();

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.Mayonnaise,
                    GDOReferences.EggYolk
                },
                Min = 2,
                Max = 2
            }
        };
    }
}