using System.Collections.Generic;
using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Appliances
{
    public class HotCrossBunsProvider : GenericProvider
    {
        public override Item ProvidedItem => GDOReferences.RawHotCrossBun;
        public override string UniqueNameID => "HotCrossBunsProvider";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("HotCrossBunsProvider").AssignMaterialsByNames();
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.HotCrossBunsProvider;
    }
}