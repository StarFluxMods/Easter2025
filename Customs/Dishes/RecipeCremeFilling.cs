using System.Collections.Generic;
using Easter2025.Utilies;
using KitchenData;
using KitchenLib.Customs;

namespace Easter2025.Customs.Dishes
{
    public class RecipeCremeFilling : CustomDish
    {
        public override string UniqueNameID => "RecipeCremeFilling";
        public override DishType Type => DishType.Base;
        public override int Difficulty => 1;

        public override bool IsUnlockable => false;
        
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.RecipeCremeFilling;
        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.RecipeCremeFilling;
    }
}