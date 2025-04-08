using System.Collections.Generic;
using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class CutRawHotCrossBun : GenericStackableItem
    {
        public override string UniqueNameID => "CutRawHotCrossBun";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CutRawHotCrossBun").AssignMaterialsByNames();
        public override List<Item.ItemProcess> Processes => new()
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Cook,
                Duration = 1,
                Result = GDOReferences.CutCookedHotCrossBun
            }
        };
    }
}