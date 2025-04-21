using System.Collections.Generic;
using Easter2025.Utilies;
using KitchenData;
using KitchenLib.Customs;

namespace Easter2025.Customs.Dishes
{
    public class DishPlasticEggs : CustomDish
    {
        public override string UniqueNameID => "DishPlasticEggs";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override DishType Type => DishType.Starter;
        public override int Difficulty => 1;

        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new Dish.MenuItem
            {
                Item = GDOReferences.PinkPlasticEgg,
                Phase = MenuPhase.Starter,
                Weight = 1,
                DynamicMenuType = DynamicMenuType.Static,
                DynamicMenuIngredient = null
            },
            
            new Dish.MenuItem
            {
                Item = GDOReferences.OrangePlasticEgg,
                Phase = MenuPhase.Starter,
                Weight = 1,
                DynamicMenuType = DynamicMenuType.Static,
                DynamicMenuIngredient = null
            },
            
            new Dish.MenuItem
            {
                Item = GDOReferences.YellowPlasticEgg,
                Phase = MenuPhase.Starter,
                Weight = 1,
                DynamicMenuType = DynamicMenuType.Static,
                DynamicMenuIngredient = null
            }
        };

        public override bool IsUnlockable => false;
        
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.HotCrossBuns;

        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.HotCrossBuns;
    }
}