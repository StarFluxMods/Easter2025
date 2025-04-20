using Easter2025.Customs.Generics;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Appliances.SceneAppliances
{
    public class EasterGround : GenericSceneAppliance
    {
        public override string UniqueNameID => "EasterGround";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("EasterGround").AssignMaterialsByNames();
    }
}