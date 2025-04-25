using System.Collections.Generic;
using Easter2025.Utilies;
using KitchenData;
using KitchenLib.Customs;

namespace Easter2025.Customs.Appliances
{
    public class GenerousBunnies : CustomAppliance
    {
        public override string UniqueNameID => "GenerousBunnies";
        public override bool IsPurchasable => false;
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.GenerousBunnies;
    }
}