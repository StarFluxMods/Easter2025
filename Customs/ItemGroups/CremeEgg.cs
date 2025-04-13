using System.Collections.Generic;
using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.ItemGroups
{
    public class CremeEgg : GenericStackableItemGroup
    {
        public override string UniqueNameID => "CremeEgg";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CremeEgg").AssignMaterialsByNames();

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.FilledHalfEgg,
                    GDOReferences.FilledHalfEgg
                },
                Min = 2,
                Max = 2
            }
        };
    }
}