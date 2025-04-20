using CustomSettingsAndLayouts;
using System.Collections.Generic;
using Easter2025.Utilies;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.RestaurantSettings
{
    public class Easter2025GardenSetting : CustomRestaurantSetting
    {
        public override string UniqueNameID => "Easter2025GardenSetting";
        public override WeatherMode WeatherMode => WeatherMode.None;

        public override List<IDecorationConfiguration> Decorators => new List<IDecorationConfiguration>
        {
            new CountrysideDecorator.DecorationsConfiguration
            {
                Cobblestone = GDOReferences.EggCobblestone,
                Ground = GDOReferences.EasterGround,
                FrontBorder = (Appliance)GDOUtils.GetExistingGDO(ApplianceReferences.LogWall),
                BorderSpacing = 1,
                Scatters = new List<CountrysideDecorator.DecorationsConfiguration.Scatter>
                {
                    new CountrysideDecorator.DecorationsConfiguration.Scatter
                    {
                        Appliance = (Appliance)GDOUtils.GetExistingGDO(ApplianceReferences.Tree),
                        Probability = 0.35f
                    },
                    new CountrysideDecorator.DecorationsConfiguration.Scatter
                    {
                        Appliance = GDOReferences.EggPile,
                        Probability = 0.1f
                    }
                }
            }
        };

        public override UnlockPack UnlockPack { get; protected set; }
        // public override Unlock StartingUnlock => (Dish)GDOUtils.GetCustomGameDataObject<EasterEggHunt>().GameDataObject;
        // public override Dish FixedDish => (Dish)GDOUtils.GetCustomGameDataObject<RoastLamb>().GameDataObject;
        // public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("EasterSnowglobe").AssignMaterialsByNames();
        public override bool AlwaysLight => true;

        public override List<(Locale, BasicInfo)> InfoList => CenteralLang.RestaurantSettings.Easter2025GardenSetting;


        public override void OnRegister(RestaurantSetting gameDataObject)
        {
            base.OnRegister(gameDataObject);
            Registry.GrantCustomSetting(gameDataObject);
        }
    }
}