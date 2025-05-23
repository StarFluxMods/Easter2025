﻿using System.Collections.Generic;
using Easter2025.Components;
using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using Easter2025.Views;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.ItemGroups
{
    public class RedEgg : GenericStackableItemGroup
    {
        public override string UniqueNameID => "RedEgg";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("RedEgg").AssignMaterialsByNames();
        public override Item DirtiesTo => GDOReferences.RedShell;
        public override List<ItemGroupView.ColourBlindLabel> Labels => new List<ItemGroupView.ColourBlindLabel>
        {
            new ItemGroupView.ColourBlindLabel
            {
                Item = GDOReferences.RedDye,
                Text = "R"
            }
        };
        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Chop,
                Duration = 1,
                Result = GDOReferences.RedSlicedEgg
            }
        };
        public override List<IItemProperty> Properties => new List<IItemProperty>
        {
            new CEggBasket.CanPlaceInBasket()
        };

        public override ItemValue ItemValue => ItemValue.SideMedium;

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.RedDye,
                    GDOReferences.BoiledEgg
                },
                Min = 2,
                Max = 2
            }
        };

        public override void OnRegister(ItemGroup gameDataObject)
        {
            base.OnRegister(gameDataObject);
            gameDataObject.Prefab.AddComponent<ColourBlindMode>().Element = gameDataObject.Prefab.GetChild("Circle");
            TootieEggs tootieEggsView = gameDataObject.Prefab.AddComponent<TootieEggs>();
            tootieEggsView.TootieEgg = gameDataObject.Prefab.GetChild("TootieEgg");
            tootieEggsView.NormalEgg = gameDataObject.Prefab.GetChild("Egg_1");
            gameDataObject.Prefab.GetChild("TootieEgg").SetActive(false);
        }
    }
}