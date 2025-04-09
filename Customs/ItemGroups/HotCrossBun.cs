using System.Collections.Generic;
using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.ItemGroups
{
    public class HotCrossBun : GenericStackableItemGroup
    {
        public override string UniqueNameID => "HotCrossBun";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("HotCrossBun").AssignMaterialsByNames();

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.CutCookedHotCrossBun,
                    GDOReferences.Butter
                },
                Min = 2,
                Max = 2
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
                        Item = GDOReferences.CutCookedHotCrossBun,
                        Objects = new List<GameObject>
                        {
                            gameDataObject.Prefab.GetChild("Hot Cross Bun Split/Top"),
                            gameDataObject.Prefab.GetChild("Hot Cross Bun Split/Bottom")
                        },
                        DrawAll = true
                    },
                    new()
                    {
                        Item = GDOReferences.Butter,
                        GameObject = gameDataObject.Prefab.GetChild("Butter")
                    }
                };
            }
        }
    }
}