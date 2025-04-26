using System.Collections.Generic;
using Easter2025.Utilies;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Dishes
{
    public class DishDyedEggs : CustomDish
    {
        public override string UniqueNameID => "DishDyedEggs";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override DishType Type => DishType.Base;
        public override int Difficulty => 2;

        public override List<string> StartingNameSet => new()
        {
            "Cracked & Colored",
            "Egg-streme Makeover",
            "Pastel & Protein",
            "Yolk and Dye",
            "Hue's Hungry?",
        };

        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.Pot,
            GDOReferences.Water,
            GDOReferences.Egg,
            GDOReferences.RedDye,
            GDOReferences.GreenDye,
            GDOReferences.BlueDye,
        };

        public override HashSet<Process> RequiredProcesses => new()
        {
            GDOReferences.Cook,
        };

        public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("DyedEggsIcon").AssignMaterialsByNames();

        public override bool IsMainThatDoesNotNeedPlates => true;

        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new Dish.MenuItem
            {
                Item = GDOReferences.RedEgg,
                Phase = MenuPhase.Main,
                Weight = 1,
                DynamicMenuType = DynamicMenuType.Static,
                DynamicMenuIngredient = null
            },
            new Dish.MenuItem
            {
                Item = GDOReferences.GreenEgg,
                Phase = MenuPhase.Main,
                Weight = 1,
                DynamicMenuType = DynamicMenuType.Static,
                DynamicMenuIngredient = null
            },
            new Dish.MenuItem
            {
                Item = GDOReferences.BlueEgg,
                Phase = MenuPhase.Main,
                Weight = 1,
                DynamicMenuType = DynamicMenuType.Static,
                DynamicMenuIngredient = null
            }
        };

        public override bool IsAvailableAsLobbyOption => true; 
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.DyedEggs;

        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.DyedEggs;
    }
}