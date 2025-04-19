using System;
using System.Collections.Generic;
using System.Reflection;
using Easter2025.Customs.LayoutProfiles;
using Easter2025.Customs.LayoutProfiles.Decorators;
using HarmonyLib;
using Kitchen;
using Kitchen.Layouts;
using KitchenData;
using KitchenLib.Utils;

namespace Easter2025.Patches
{
    [HarmonyPatch(typeof(LayoutDecorator), "AttemptDecoration")]
    public class LayoutDecoratorPatch
    {
        static bool Prefix(LayoutDecorator __instance)
        {
            FieldInfo _Blueprint = ReflectionUtils.GetField<LayoutDecorator>("Blueprint");
            FieldInfo _Profile = ReflectionUtils.GetField<LayoutDecorator>("Profile");
            FieldInfo _Setting = ReflectionUtils.GetField<LayoutDecorator>("Setting");

            LayoutBlueprint Blueprint = (LayoutBlueprint)_Blueprint.GetValue(__instance);
            LayoutProfile Profile = (LayoutProfile)_Profile.GetValue(__instance);
            RestaurantSetting Setting = (RestaurantSetting)_Setting.GetValue(__instance);

            if (Profile.ID != GDOUtils.GetCustomGameDataObject<BunnyLayout>().ID && Profile.ID != GDOUtils.GetCustomGameDataObject<GardenBunnyLayout>().ID) return true;

            
            __instance.Decorations = new List<CLayoutAppliancePlacement>();
            Decorator eggHuntDecorator = new EasterDiningDecorator().Setup(Blueprint, Profile, null, __instance.Decorations);
            Decorator kitchenDecorator = new EasterKitchenDecorator().Setup(Blueprint, Profile, null, __instance.Decorations);
            
            foreach (Room room in Blueprint.Rooms())
            {
                if (room.Type == RoomType.Dining || room.Type == RoomType.Garden)
                {
                    int easterRoomAttemps = 5;
                    while (easterRoomAttemps-- > 0 && !eggHuntDecorator.Decorate(room))
                    {
                    }
                    if (easterRoomAttemps <= 0)
                    {
                        throw new LayoutFailureException("Failed to decorate dining room");
                    }
                }
                if (room.Type == RoomType.Kitchen)
                {
                    kitchenDecorator.Decorate(room);
                }
            }
            foreach (IDecorationConfiguration decorationConfiguration in Setting.Decorators)
            {
                try
                {
                    Decorator decorator3 = (Decorator)decorationConfiguration.Decorator;
                    decorator3.Setup(Blueprint, Profile, decorationConfiguration, __instance.Decorations);
                    decorator3.Decorate(default(Room));
                }
                catch (Exception ex)
                {
                    throw new LayoutFailureException(string.Format("Failed to apply decorator {0}: {1}", decorationConfiguration.Decorator, ex));
                }
            }
            
            return false;
        }
    }
}