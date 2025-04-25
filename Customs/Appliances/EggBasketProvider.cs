using System.Collections.Generic;
using Easter2025.Utilies;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Appliances
{
    public class EggBasketProvider : CustomAppliance
    {
        public override string UniqueNameID => "EggBasketProvider";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("EggBasketProvider").AssignMaterialsByNames();
        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>
        {
            new CItemHolder(),
            new CItemProvider
            {
                Item = GDOReferences.EggBasket.ID,
                Available = 1,
                Maximum = 1,
                PreventReturns = true,
                AutoPlaceOnHolder = true
            }
        };

        public override bool SellOnlyAsDuplicate => true;
        public override bool IsPurchasable => true;
        public override PriceTier PriceTier => PriceTier.Medium;
        public override ShoppingTags ShoppingTags => ShoppingTags.Cooking | ShoppingTags.Misc;
        public override List<Process> RequiresProcessForShop => new List<Process>
        {
            GDOReferences.SearchBush
        };
        
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.EggBasketProvider;

        public override void OnRegister(Appliance gameDataObject)
        {
            base.OnRegister(gameDataObject);

            HoldPointContainer holdPointContainer = gameDataObject.Prefab.AddComponent<HoldPointContainer>();
            LimitedItemSourceView limitedItemSourceView = gameDataObject.Prefab.AddComponent<LimitedItemSourceView>();

            holdPointContainer.HoldPoint = gameDataObject.Prefab.GetChild("HoldPoint").transform;
            
            limitedItemSourceView.HeldItemPosition = gameDataObject.Prefab.GetChild("HoldPoint").transform;
            limitedItemSourceView.Items = new List<GameObject>
            {
                gameDataObject.Prefab.GetChild("HoldPoint/EggBasket")
            };
        }
    }
}