using System.Collections.Generic;
using KitchenData;

namespace Easter2025.Utilies
{
    public static class CenteralLang
    {
        public static class Appliances
        {
            public static List<(Locale, ApplianceInfo)> HotCrossBunsProvider => new()
            {
                (Locale.English, new ApplianceInfo { Name = "Hot Cross Buns", Description = "Provides Hot Cross Buns" }),
            };
        }
    }
}