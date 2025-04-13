using System.Collections.Generic;
using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.ItemGroups
{
    public class BlueEgg : GenericStackableItemGroup
    {
        public override string UniqueNameID => "BlueEgg";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("BlueEgg").AssignMaterialsByNames();
        public override Item DirtiesTo => GDOReferences.BlueShell;
        public override List<ItemGroupView.ColourBlindLabel> Labels => new List<ItemGroupView.ColourBlindLabel>
        {
            new ItemGroupView.ColourBlindLabel
            {
                Item = GDOReferences.BlueDye,
                Text = "B"
            }
        };
        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Chop,
                Duration = 1,
                Result = GDOReferences.BlueSlicedEgg
            }
        };

        public override ItemValue ItemValue => ItemValue.SideMedium;

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.BlueDye,
                    GDOReferences.BoiledEgg
                },
                Min = 2,
                Max = 2
            }
        };

        public override void OnRegister(ItemGroup gameDataObject)
        {
            base.OnRegister(gameDataObject);
            gameDataObject.Prefab.AddComponent<ColourBlindMode>().Element = gameDataObject.Prefab.GetChild("Octagon");
        }
    }
}