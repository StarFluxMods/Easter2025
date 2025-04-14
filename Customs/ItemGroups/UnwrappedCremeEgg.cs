using System.Collections.Generic;
using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using Sony.NP;
using UnityEngine;

namespace Easter2025.Customs.ItemGroups
{
    public class UnwrappedCremeEgg : GenericStackableItemGroup
    {
        public override string UniqueNameID => "UnwrappedCremeEgg";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("UnwrappedCremeEgg").AssignMaterialsByNames();

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.CremeEgg,
                    GDOReferences.Wrapper
                },
                Min = 2,
                Max = 2
            }
        };

        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Knead,
                Duration = 1,
                Result = GDOReferences.WrappedCremeEgg
            }
        };
    }
}