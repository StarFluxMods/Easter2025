using System.Collections.Generic;
using Easter2025.Utilies;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Appliances
{
    public class DyeProvider : CustomAppliance
    {
        public override string UniqueNameID => "DyeProvider";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("DyeProvider").AssignMaterialsByNames();
        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>
        {
            KitchenPropertiesUtils.GetUnlimitedCItemProvider(GDOReferences.RedDye.ID),
            new CVariableProvider
            {
                Current = 0,
                Provide1 = GDOReferences.RedDye.ID,
                Provide2 = GDOReferences.GreenDye.ID,
                Provide3 = GDOReferences.BlueDye.ID
            }
        };

        public override bool SellOnlyAsDuplicate => true;
        public override bool IsPurchasable => true;
        public override PriceTier PriceTier => PriceTier.Medium;
        public override ShoppingTags ShoppingTags => ShoppingTags.Cooking | ShoppingTags.Misc;
        
        public override void OnRegister(Appliance gameDataObject)
        {
            base.OnRegister(gameDataObject);
            VariableProviderView variableProviderView = gameDataObject.Prefab.AddComponent<VariableProviderView>();
            variableProviderView.Animator = gameDataObject.Prefab.GetComponent<Animator>();
            gameDataObject.Prefab.GetChild("Bottles/BlueDyeBottle").AddComponent<ColourBlindMode>().Element = gameDataObject.Prefab.GetChild("Bottles/BlueDyeBottle/Octagon");
            gameDataObject.Prefab.GetChild("Bottles/GreenDyeBottle").AddComponent<ColourBlindMode>().Element = gameDataObject.Prefab.GetChild("Bottles/GreenDyeBottle/Square");
            gameDataObject.Prefab.GetChild("Bottles/RedDyeBottle").AddComponent<ColourBlindMode>().Element = gameDataObject.Prefab.GetChild("Bottles/RedDyeBottle/Circle");
        }
    }
}