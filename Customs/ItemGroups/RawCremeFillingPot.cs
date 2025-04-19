using System.Collections.Generic;
using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.ItemGroups
{
    public class RawCremeFillingPot : GenericStackableItemGroup
    {
        public override string UniqueNameID => "RawCremeFillingPot";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("RawCremeFillingPot").AssignMaterialsByNames();
        public override Item DisposesTo => GDOReferences.Pot;

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.Pot,
                    GDOReferences.Milk
                },
                IsMandatory = true,
                Min = 2,
                Max = 2
            },
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.Butter,
                    GDOReferences.Sugar,
                },
                Min = 2,
                Max = 2
            }
        };

        public override List<Item.ItemProcess> Processes => new()
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Cook,
                Duration = 5f,
                Result = GDOReferences.CookedCremeFillingPot
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
                        Item = GDOReferences.Butter,
                        GameObject = gameDataObject.Prefab.GetChild("Butter")
                    },
                    new()
                    {
                        Item = GDOReferences.Sugar,
                        GameObject = gameDataObject.Prefab.GetChild("Sugar")
                    }
                };
            }
        }
    }
}