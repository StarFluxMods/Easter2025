using System.Collections.Generic;
using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.ItemGroups
{
    public class FilledEggMould : GenericStackableItemGroup
    {
        public override string UniqueNameID => "FilledEggMould";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("FilledEggMould").AssignMaterialsByNames();

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.EggMould,
                    GDOReferences.ChocolateMelted
                },
                Min = 2,
                Max = 2
            }
        };

        public override Item.ItemProcess AutomaticItemProcess => new Item.ItemProcess
        {
            Process = GDOReferences.SteepTea,
            Duration = 1,
            Result = GDOReferences.PreppedEggMould,
        };

        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.SteepTea,
                Duration = 1,
                Result = GDOReferences.PreppedEggMould,
            }
        };
    }
}