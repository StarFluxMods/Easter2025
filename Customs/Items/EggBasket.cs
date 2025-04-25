using System.Collections.Generic;
using Easter2025.Components;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class EggBasket : CustomItem
    {
        public override string UniqueNameID => "EggBasket";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("EggBasket").AssignMaterialsByNames();
        public override bool IsIndisposable => true;
        public override int MaxOrderSharers => 3;

        public override List<IItemProperty> Properties => new List<IItemProperty>
        {
            new CToolStorage
            {
                Capacity = 3
            },
            new CEquippableTool
            {
                CanHoldItems = false
            },
            new CEggBasket()
        };



        public override void OnRegister(Item item)
        {
            List<GameObject> storage = new List<GameObject>
            {
                GameObjectUtils.GetChildObject(item.Prefab, "HoldPoint1"),
                GameObjectUtils.GetChildObject(item.Prefab, "HoldPoint2"),
                GameObjectUtils.GetChildObject(item.Prefab, "HoldPoint3")
            };
            ItemVariableStorageView obj = item.Prefab.AddComponent<ItemVariableStorageView>();
            obj.Storage = storage;
        }
    }
}