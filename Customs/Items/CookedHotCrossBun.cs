using System.Collections.Generic;
using Easter2025.Components;
using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using KitchenData;
using KitchenLib.References;
using KitchenLib.Utils;
using Unity.Collections;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class CookedHotCrossBun : GenericStackableItem
    {
        public override string UniqueNameID => "CookedHotCrossBun";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CookedHotCrossBun").AssignMaterialsByNames();
        public override Appliance DedicatedProvider => GDOReferences.HotCrossBunsProvider;
        public override List<IItemProperty> Properties => new List<IItemProperty>
        {
            new CHiddenBurnProcess
            {
                Result = new FixedListInt64
                {
                    GDOReferences.FlamingHotCrossBun.ID
                },
                BurnableSurfaces = new FixedListInt64
                {
                    ApplianceReferences.Hob,
                    ApplianceReferences.HobDanger,
                    ApplianceReferences.HobSafe,
                    ApplianceReferences.HobStarting,
                },
                BurnTimeInSeconds = 15
            }
        };

        public override List<Item.ItemProcess> Processes => new()
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Chop,
                Duration = 1,
                Result = GDOReferences.CutCookedHotCrossBun
            }
        };
    }
}