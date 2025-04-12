using System.Collections.Generic;
using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class BoiledEgg : GenericStackableItem
    {
        public override string UniqueNameID => "BoiledEgg";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("BoiledEgg").AssignMaterialsByNames();
        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Chop,
                Duration = 1,
                Result = GDOReferences.SlicedEgg
            }
        };
    }
}