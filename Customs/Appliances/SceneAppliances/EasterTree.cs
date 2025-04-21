using System.Collections.Generic;
using Easter2025.Customs.Generics;
using Easter2025.Views.Local;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Appliances.SceneAppliances
{
    public class EasterTree : GenericSceneAppliance
    {
        public override string UniqueNameID => "EasterTree";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("EasterTree").AssignMaterialsByNames();
        

        public override void OnRegister(Appliance gameDataObject)
        {
            EggPileView eggPileView = Prefab.AddComponent<EggPileView>();
            eggPileView.EggContainers = new List<GameObject>
            {
                gameDataObject.Prefab.GetChild("Eggs/Egg Container 1"),
                gameDataObject.Prefab.GetChild("Eggs/Egg Container 2"),
                gameDataObject.Prefab.GetChild("Eggs/Egg Container 3"),
                gameDataObject.Prefab.GetChild("Eggs/Egg Container 4"),
                gameDataObject.Prefab.GetChild("Eggs/Egg Container 5"),
                gameDataObject.Prefab.GetChild("Eggs/Egg Container 6"),
            };
            base.OnRegister(gameDataObject);
        }
    }
}