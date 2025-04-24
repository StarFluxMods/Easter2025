using System.Collections.Generic;
using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Appliances.Decorations
{
    public class MountedCarrots : GenericDecorationAppliance
    {
        public override string UniqueNameID => "MountedCarrots";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("MountedCarrots").AssignMaterialsByNames();
        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>
        {
            new CMustHaveWall()
        };
        public override OccupancyLayer Layer => OccupancyLayer.Wall;
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.MountedCarrots;
    }
}