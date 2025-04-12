using System.Collections.Generic;
using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.ItemGroups
{
    public class RawEggPot : GenericStackableItemGroup
    {
        public override string UniqueNameID => "RawEggPot";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("RawEggPot").AssignMaterialsByNames();
        public override Item DisposesTo => GDOReferences.Pot;

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.Pot,
                    GDOReferences.Water
                },
                IsMandatory = true,
                Min = 2,
                Max = 2
            },
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.Egg,
                    GDOReferences.Egg,
                    GDOReferences.Egg,
                },
                Min = 3,
                Max = 3
            }
        };

        public override List<Item.ItemProcess> Processes => new()
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Cook,
                Duration = 1,
                Result = GDOReferences.BoiledEggPot
            }
        };

        public override void OnRegister(ItemGroup gameDataObject)
        {
            base.OnRegister(gameDataObject);
            if (gameDataObject.Prefab.TryGetComponent(out ItemGroupView itemGroupView))
            {
                itemGroupView.ComponentGroups = new List<ItemGroupView.ComponentGroup>
                {
                    new()
                    {
                        Item = GDOReferences.Egg,
                        Objects = new List<GameObject>
                        {
                            gameDataObject.Prefab.GetChild("Egg1"),
                            gameDataObject.Prefab.GetChild("Egg2"),
                            gameDataObject.Prefab.GetChild("Egg3"),
                        }
                    }
                };
            }
        }
    }
}