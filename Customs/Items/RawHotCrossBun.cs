using System.Collections.Generic;
using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class RawHotCrossBun : GenericStackableItem
    {
        public override string UniqueNameID => "RawHotCrossBun";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("RawHotCrossBun").AssignMaterialsByNames();
        public override Appliance DedicatedProvider => GDOReferences.HotCrossBunsProvider;
        public override List<Item.ItemProcess> Processes => new()
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Chop,
                Duration = 1,
                Result = GDOReferences.CutRawHotCrossBun
            },
            new Item.ItemProcess
            {
                Process = GDOReferences.Cook,
                Duration = 1,
                Result = GDOReferences.CookedHotCrossBun
            }
        };
    }
}