using System.Collections.Generic;
using Easter2025.Customs.Generics;
using Easter2025.Views.Local;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Appliances.SceneAppliances
{
    public class EggPile : GenericSceneAppliance
    {
        public override string UniqueNameID => "EggPile";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("EggPile").AssignMaterialsByNames();
        

        public override void OnRegister(Appliance gameDataObject)
        {
            base.OnRegister(gameDataObject);
            EggPileView eggPileView = gameDataObject.Prefab.AddComponent<EggPileView>();
            eggPileView.EggContainers = new List<GameObject>
            {
                gameDataObject.Prefab.GetChild("EggContainer/Egg_1"),
                gameDataObject.Prefab.GetChild("EggContainer/Egg_2"),
                gameDataObject.Prefab.GetChild("EggContainer/Egg_3"),
            };
            
            RandomRotationView randomRotationView = gameDataObject.Prefab.AddComponent<RandomRotationView>();
            randomRotationView.Container = gameDataObject.Prefab.GetChild("EggContainer");
        }
    }
}