using System.Collections.Generic;
using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class CookedHotCrossBun : GenericStackableItem
    {
        public override string UniqueNameID => "CookedHotCrossBun";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CookedHotCrossBun").AssignMaterialsByNames();
        public override Appliance DedicatedProvider => GDOReferences.HotCrossBunsProvider;

        public override List<Item.ItemProcess> Processes => new()
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Chop,
                Duration = 1,
                Result = GDOReferences.CutCookedHotCrossBun
            },
            new Item.ItemProcess
            {
                Process = GDOReferences.Cook,
                Duration = 1,
                Result = GDOReferences.FlamingHotCrossBun
            }
        };
    }
}