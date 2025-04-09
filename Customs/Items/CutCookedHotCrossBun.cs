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
    public class CutCookedHotCrossBun : GenericStackableItem
    {
        public override string UniqueNameID => "CutCookedHotCrossBun";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CutCookedHotCrossBun").AssignMaterialsByNames();
        
        public override List<IItemProperty> Properties => new List<IItemProperty>
        {
            new CHiddenBurnProcess
            {
                Result = new FixedListInt64
                {
                    GDOReferences.CutFlamingHotCrossBun.ID
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
    }
}