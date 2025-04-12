using System.Collections.Generic;
using System.Reflection;
using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class BoiledEggPot : GenericStackableItem
    {
        public override string UniqueNameID => "BoiledEggPot";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("BoiledEggPot").AssignMaterialsByNames();
        public override Item DisposesTo => GDOReferences.Pot;
        public override Item SplitSubItem => GDOReferences.BoiledEgg;
        public override List<Item> SplitDepletedItems => new List<Item> { GDOReferences.Pot};
        public override int SplitCount => 3;
        
        public override void OnRegister(Item gameDataObject)
        {
            base.OnRegister(gameDataObject);
            ObjectsSplittableView objectsSplittableView = gameDataObject.Prefab.AddComponent<ObjectsSplittableView>();
            FieldInfo objectsInfo = ReflectionUtils.GetField<ObjectsSplittableView>("Objects");
            List<GameObject> objects = new List<GameObject>
            {
                gameDataObject.Prefab.GetChild("Egg1"),
                gameDataObject.Prefab.GetChild("Egg2"),
                gameDataObject.Prefab.GetChild("Egg3")
            };
            objectsInfo.SetValue(objectsSplittableView, objects);
        }
    }
}