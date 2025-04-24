using System.Collections.Generic;
using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Appliances.Decorations
{
    public class GrassBunny : GenericDecorationAppliance
    {
        public override string UniqueNameID => "GrassBunny";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("GrassBunny").AssignMaterialsByNames();
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.GrassBunny;
    }
}