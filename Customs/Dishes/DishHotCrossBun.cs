using System.Collections.Generic;
using Easter2025.Utilies;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Dishes
{
    public class DishHotCrossBun : CustomDish
    {
        public override string UniqueNameID => "DishHotCrossBun";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override DishType Type => DishType.Starter;
        public override int Difficulty => 1;

        public override List<string> StartingNameSet => new()
        {
            "Bun Intended",
            "Too Hot to Cross",
            "Criss Cross Delish",
            "Bun Appétit",
            "Rise and Cross",
        };

        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.RawHotCrossBun,
            GDOReferences.Butter,
        };

        public override HashSet<Process> RequiredProcesses => new()
        {
            GDOReferences.Cook,
            GDOReferences.Chop,
        };

        public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("HotCrossBunIcon").AssignMaterialsByNames();

        public override bool IsMainThatDoesNotNeedPlates => true;

        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new Dish.MenuItem
            {
                Item = GDOReferences.HotCrossBun,
                Phase = MenuPhase.Starter,
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
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.HotCrossBuns;

        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.HotCrossBuns;
    }
}