using System.Collections.Generic;
using Easter2025.Utilies;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Dishes
{
    public class DishEasterBread : CustomDish
    {
        public override string UniqueNameID => "DishEasterBread";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override DishType Type => DishType.Dessert;
        public override int Difficulty => 1;

        public override List<string> StartingNameSet => new()
        {
            "",
            "",
            "",
            "",
            "",
        };

        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.Pot,
            GDOReferences.Water,
            GDOReferences.Egg,
            GDOReferences.Flour,
        };

        public override HashSet<Process> RequiredProcesses => new()
        {
            GDOReferences.Cook
        };

        // public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("HotCrossBunIcon").AssignMaterialsByNames();

        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new Dish.MenuItem
            {
                Item = GDOReferences.EasterBread,
                Phase = MenuPhase.Dessert,
                Weight = 1,
                DynamicMenuType = DynamicMenuType.Static,
                DynamicMenuIngredient = null
            }
        };

        public override List<Unlock> HardcodedRequirements => new List<Unlock>
        {
            GDOReferences.DishDyedEggs
        };

        public override bool IsAvailableAsLobbyOption => Mod.ENABLE_ADDITIONAL_LOBBY_DISHES;
        // public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.HotCrossBuns;

        // public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.HotCrossBuns;
    }
}