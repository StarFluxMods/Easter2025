using System.Collections.Generic;
using Easter2025.Utilies;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Dishes
{
    public class DishCremeEgg : CustomDish
    {
        public override string UniqueNameID => "DishCremeEgg";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override DishType Type => DishType.Dessert;
        public override int Difficulty => 3;

        public override List<string> StartingNameSet => new()
        {
            "Gooey Goodness",
            "Egg-streme Indulgence",
            "Cracked and Packed",
            "The Yolk of Luxury",
            "What the Fudge?!",
        };

        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.Sugar,
            GDOReferences.Milk,
            GDOReferences.Chocolate,
            GDOReferences.Butter,
            GDOReferences.EggMould,
            GDOReferences.Pot,
            GDOReferences.WrapperRoll,
        };

        public override HashSet<Process> RequiredProcesses => new()
        {
            GDOReferences.SteepTea,
            GDOReferences.Chop,
            GDOReferences.Knead,
        };
        
        public override List<Dish> AlsoAddRecipes => new List<Dish>
        {
            GDOReferences.RecipeCremeFilling
        };

        public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("CremeEggIcon").AssignMaterialsByNames();

        public override bool IsMainThatDoesNotNeedPlates => true;

        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new Dish.MenuItem
            {
                Item = GDOReferences.HotCrossBun,
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
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.CremeEgg;

        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.CremeEgg;
    }
}