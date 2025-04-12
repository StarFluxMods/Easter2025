using System.Collections.Generic;
using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.ItemGroups
{
    public class RedRawEasterBread : GenericStackableItemGroup
    {
        public override string UniqueNameID => "RedRawEasterBread";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("RedRawEasterBread").AssignMaterialsByNames();

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.RedEgg,
                    GDOReferences.Dough
                },
                Min = 2,
                Max = 2
            }
        };

        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Cook,
                Duration = 1,
                Result = GDOReferences.RedEasterBread
            }
        };
    }
}