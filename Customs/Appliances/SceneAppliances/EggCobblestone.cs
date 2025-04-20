using Easter2025.Customs.Generics;
using Easter2025.Views.Local;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Appliances.SceneAppliances
{
    public class EggCobblestone : GenericSceneAppliance
    {
        public override string UniqueNameID => "EggCobblestone";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("EggCobblestone").AssignMaterialsByNames();
        

        public override void OnRegister(Appliance gameDataObject)
        {
            base.OnRegister(gameDataObject);
            RandomRotationView randomRotationView = gameDataObject.Prefab.AddComponent<RandomRotationView>();
            randomRotationView.Container = gameDataObject.Prefab.GetChild("Container");
            randomRotationView.min = 0;
            randomRotationView.max = 360;
            
            
            RandomPlacementView randomPlacementView = gameDataObject.Prefab.AddComponent<RandomPlacementView>();
            randomPlacementView.Container = gameDataObject.Prefab.GetChild("Container");
            randomPlacementView.min = new(-0.1f,0,-0.1f);
            randomPlacementView.max = new (0.1f,0,0.1f);
        }
    }
}