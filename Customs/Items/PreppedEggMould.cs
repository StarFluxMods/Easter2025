using System.Collections.Generic;
using System.Reflection;
using Easter2025.Utilies;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class PreppedEggMould : CustomItem
    {
        public override string UniqueNameID => "PreppedEggMould";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PreppedEggMould").AssignMaterialsByNames();
        public override Item DisposesTo => GDOReferences.EggMould;
        public override Item SplitSubItem => GDOReferences.HalfEgg;
        public override List<Item> SplitDepletedItems => new List<Item> { GDOReferences.EggMould };
        public override int SplitCount => 10;
        
        public override void OnRegister(Item gameDataObject)
        {
            base.OnRegister(gameDataObject);
            ObjectsSplittableView objectsSplittableView = gameDataObject.Prefab.AddComponent<ObjectsSplittableView>();
            FieldInfo objectsInfo = ReflectionUtils.GetField<ObjectsSplittableView>("Objects");
            List<GameObject> objects = new List<GameObject>
            {
                gameDataObject.Prefab.GetChild("Eggs/HalfEgg1"),
                gameDataObject.Prefab.GetChild("Eggs/HalfEgg2"),
                gameDataObject.Prefab.GetChild("Eggs/HalfEgg3"),
                gameDataObject.Prefab.GetChild("Eggs/HalfEgg4"),
                gameDataObject.Prefab.GetChild("Eggs/HalfEgg5"),
                gameDataObject.Prefab.GetChild("Eggs/HalfEgg6"),
                gameDataObject.Prefab.GetChild("Eggs/HalfEgg7"),
                gameDataObject.Prefab.GetChild("Eggs/HalfEgg8"),
                gameDataObject.Prefab.GetChild("Eggs/HalfEgg9"),
                gameDataObject.Prefab.GetChild("Eggs/HalfEgg10"),
            };
            objectsInfo.SetValue(objectsSplittableView, objects);
        }
    }
}