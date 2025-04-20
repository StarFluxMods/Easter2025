using Easter2025.Customs.Appliances;
using Easter2025.Customs.Appliances.SceneAppliances;
using Easter2025.Customs.Decor;
using Easter2025.Customs.Dishes;
using Easter2025.Customs.ItemGroups;
using Easter2025.Customs.Items;
using Easter2025.Customs.LayoutProfiles;
using Easter2025.Customs.PlayerCosmetics;
using Easter2025.Customs.RestaurantSettings;
using KitchenData;
using KitchenLib.References;
using KitchenLib.Utils;

namespace Easter2025.Utilies
{
    public class GDOReferences
    {
        #region Vanilla

        #region Appliance

        public static Appliance WallpaperApplicator => (Appliance)GDOUtils.GetExistingGDO(ApplianceReferences.WallpaperApplicator);

        #endregion

        #region Item

        public static Item Plate => (Item)GDOUtils.GetExistingGDO(ItemReferences.Plate);
        public static Item PlateDirty => (Item)GDOUtils.GetExistingGDO(ItemReferences.PlateDirty);
        public static Item Butter => (Item)GDOUtils.GetExistingGDO(ItemReferences.Butter);
        public static Item Sugar => (Item)GDOUtils.GetExistingGDO(ItemReferences.Sugar);
        public static Item Egg => (Item)GDOUtils.GetExistingGDO(ItemReferences.Egg);
        public static Item Pot => (Item)GDOUtils.GetExistingGDO(ItemReferences.Pot);
        public static Item Water => (Item)GDOUtils.GetExistingGDO(ItemReferences.Water);
        public static Item Oil => (Item)GDOUtils.GetExistingGDO(ItemReferences.Oil);
        public static Item Dough => (Item)GDOUtils.GetExistingGDO(ItemReferences.Dough);
        public static Item Flour => (Item)GDOUtils.GetExistingGDO(ItemReferences.Flour);
        public static Item ChocolateMelted => (Item)GDOUtils.GetExistingGDO(ItemReferences.ChocolateMelted);
        public static Item Chocolate => (Item)GDOUtils.GetExistingGDO(ItemReferences.Chocolate);
        public static Item Milk => (Item)GDOUtils.GetExistingGDO(ItemReferences.Milk);

        #endregion

        #region ItemGroup

        public static ItemGroup Mayonnaise => (ItemGroup)GDOUtils.GetExistingGDO(ItemGroupReferences.Mayonnaise);

        #endregion

        #region Process

        public static Process Chop => (Process)GDOUtils.GetExistingGDO(ProcessReferences.Chop);
        public static Process Cook => (Process)GDOUtils.GetExistingGDO(ProcessReferences.Cook);
        public static Process Clean => (Process)GDOUtils.GetExistingGDO(ProcessReferences.Clean);
        public static Process SteepTea => (Process)GDOUtils.GetExistingGDO(ProcessReferences.SteepTea);
        public static Process Knead => (Process)GDOUtils.GetExistingGDO(ProcessReferences.Knead);

        #endregion

        #endregion

        #region RestaurantSetting

        public static RestaurantSetting Easter2025GardenSetting => (RestaurantSetting)GDOUtils.GetCustomGameDataObject<Easter2025GardenSetting>().GameDataObject;
        public static RestaurantSetting Easter2025Setting => (RestaurantSetting)GDOUtils.GetCustomGameDataObject<Easter2025Setting>().GameDataObject;

        #endregion

        #region PlayerCosmetic

        public static PlayerCosmetic BunnyTail => (PlayerCosmetic)GDOUtils.GetCustomGameDataObject<BunnyTail>().GameDataObject;

        #endregion

        #region LayoutProfile

        public static LayoutProfile BunnyLayout => (LayoutProfile)GDOUtils.GetCustomGameDataObject<BunnyLayout>().GameDataObject;
        public static LayoutProfile GardenBunnyLayout => (LayoutProfile)GDOUtils.GetCustomGameDataObject<GardenBunnyLayout>().GameDataObject;

        #endregion

        #region Item

        public static Item BlueDeYolkedSlicedEgg => (Item)GDOUtils.GetCustomGameDataObject<BlueDeYolkedSlicedEgg>().GameDataObject;
        public static Item BlueDye => (Item)GDOUtils.GetCustomGameDataObject<BlueDye>().GameDataObject;
        public static Item BlueEasterBread => (Item)GDOUtils.GetCustomGameDataObject<BlueEasterBread>().GameDataObject;
        public static Item BlueShell => (Item)GDOUtils.GetCustomGameDataObject<BlueShell>().GameDataObject;
        public static Item BlueSlicedEgg => (Item)GDOUtils.GetCustomGameDataObject<BlueSlicedEgg>().GameDataObject;
        public static Item BoiledEgg => (Item)GDOUtils.GetCustomGameDataObject<BoiledEgg>().GameDataObject;
        public static Item BoiledEggPot => (Item)GDOUtils.GetCustomGameDataObject<BoiledEggPot>().GameDataObject;
        public static Item BurnedHotCrossBun => (Item)GDOUtils.GetCustomGameDataObject<BurnedHotCrossBun>().GameDataObject;
        public static Item CookedCremeFillingPot => (Item)GDOUtils.GetCustomGameDataObject<CookedCremeFillingPot>().GameDataObject;
        public static Item CookedHotCrossBun => (Item)GDOUtils.GetCustomGameDataObject<CookedHotCrossBun>().GameDataObject;
        public static Item CremeFilling => (Item)GDOUtils.GetCustomGameDataObject<CremeFilling>().GameDataObject;
        public static Item CutBurnedHotCrossBun => (Item)GDOUtils.GetCustomGameDataObject<CutBurnedHotCrossBun>().GameDataObject;
        public static Item CutCookedHotCrossBun => (Item)GDOUtils.GetCustomGameDataObject<CutCookedHotCrossBun>().GameDataObject;
        public static Item CutFlamingHotCrossBun => (Item)GDOUtils.GetCustomGameDataObject<CutFlamingHotCrossBun>().GameDataObject;
        public static Item CutRawHotCrossBun => (Item)GDOUtils.GetCustomGameDataObject<CutRawHotCrossBun>().GameDataObject;
        public static Item DeYolkedSlicedEgg => (Item)GDOUtils.GetCustomGameDataObject<DeYolkedSlicedEgg>().GameDataObject;
        public static Item EasterBread => (Item)GDOUtils.GetCustomGameDataObject<EasterBread>().GameDataObject;
        public static Item EggMould => (Item)GDOUtils.GetCustomGameDataObject<EggMould>().GameDataObject;
        public static Item EggYolk => (Item)GDOUtils.GetCustomGameDataObject<EggYolk>().GameDataObject;
        public static Item FlamingHotCrossBun => (Item)GDOUtils.GetCustomGameDataObject<FlamingHotCrossBun>().GameDataObject;
        public static Item GreenDeYolkedSlicedEgg => (Item)GDOUtils.GetCustomGameDataObject<GreenDeYolkedSlicedEgg>().GameDataObject;
        public static Item GreenDye => (Item)GDOUtils.GetCustomGameDataObject<GreenDye>().GameDataObject;
        public static Item GreenEasterBread => (Item)GDOUtils.GetCustomGameDataObject<GreenEasterBread>().GameDataObject;
        public static Item GreenShell => (Item)GDOUtils.GetCustomGameDataObject<GreenShell>().GameDataObject;
        public static Item GreenSlicedEgg => (Item)GDOUtils.GetCustomGameDataObject<GreenSlicedEgg>().GameDataObject;
        public static Item HalfEgg => (Item)GDOUtils.GetCustomGameDataObject<HalfEgg>().GameDataObject;
        public static Item PreppedEggMould => (Item)GDOUtils.GetCustomGameDataObject<PreppedEggMould>().GameDataObject;
        public static Item RawHotCrossBun => (Item)GDOUtils.GetCustomGameDataObject<RawHotCrossBun>().GameDataObject;
        public static Item RedDeYolkedSlicedEgg => (Item)GDOUtils.GetCustomGameDataObject<RedDeYolkedSlicedEgg>().GameDataObject;
        public static Item RedDye => (Item)GDOUtils.GetCustomGameDataObject<RedDye>().GameDataObject;
        public static Item RedEasterBread => (Item)GDOUtils.GetCustomGameDataObject<RedEasterBread>().GameDataObject;
        public static Item RedShell => (Item)GDOUtils.GetCustomGameDataObject<RedShell>().GameDataObject;
        public static Item RedSlicedEgg => (Item)GDOUtils.GetCustomGameDataObject<RedSlicedEgg>().GameDataObject;
        public static Item SlicedEgg => (Item)GDOUtils.GetCustomGameDataObject<SlicedEgg>().GameDataObject;
        public static Item WrappedCremeEgg => (Item)GDOUtils.GetCustomGameDataObject<WrappedCremeEgg>().GameDataObject;
        public static Item Wrapper => (Item)GDOUtils.GetCustomGameDataObject<Wrapper>().GameDataObject;
        public static Item WrapperRoll => (Item)GDOUtils.GetCustomGameDataObject<WrapperRoll>().GameDataObject;

        #endregion

        #region ItemGroup

        public static ItemGroup BlueDevilledEgg => (ItemGroup)GDOUtils.GetCustomGameDataObject<BlueDevilledEgg>().GameDataObject;
        public static ItemGroup BlueEgg => (ItemGroup)GDOUtils.GetCustomGameDataObject<BlueEgg>().GameDataObject;
        public static ItemGroup BlueRawEasterBread => (ItemGroup)GDOUtils.GetCustomGameDataObject<BlueRawEasterBread>().GameDataObject;
        public static ItemGroup CremeEgg => (ItemGroup)GDOUtils.GetCustomGameDataObject<CremeEgg>().GameDataObject;
        public static ItemGroup DevilledEgg => (ItemGroup)GDOUtils.GetCustomGameDataObject<DevilledEgg>().GameDataObject;
        public static ItemGroup FilledEggMould => (ItemGroup)GDOUtils.GetCustomGameDataObject<FilledEggMould>().GameDataObject;
        public static ItemGroup FilledHalfEgg => (ItemGroup)GDOUtils.GetCustomGameDataObject<FilledHalfEgg>().GameDataObject;
        public static ItemGroup GreenDevilledEgg => (ItemGroup)GDOUtils.GetCustomGameDataObject<GreenDevilledEgg>().GameDataObject;
        public static ItemGroup GreenEgg => (ItemGroup)GDOUtils.GetCustomGameDataObject<GreenEgg>().GameDataObject;
        public static ItemGroup GreenRawEasterBread => (ItemGroup)GDOUtils.GetCustomGameDataObject<GreenRawEasterBread>().GameDataObject;
        public static ItemGroup HotCrossBun => (ItemGroup)GDOUtils.GetCustomGameDataObject<HotCrossBun>().GameDataObject;
        public static ItemGroup MixedEggYolk => (ItemGroup)GDOUtils.GetCustomGameDataObject<MixedEggYolk>().GameDataObject;
        public static ItemGroup RawCremeFillingPot => (ItemGroup)GDOUtils.GetCustomGameDataObject<RawCremeFillingPot>().GameDataObject;
        public static ItemGroup RawEasterBread => (ItemGroup)GDOUtils.GetCustomGameDataObject<RawEasterBread>().GameDataObject;
        public static ItemGroup RawEggPot => (ItemGroup)GDOUtils.GetCustomGameDataObject<RawEggPot>().GameDataObject;
        public static ItemGroup RedDevilledEgg => (ItemGroup)GDOUtils.GetCustomGameDataObject<RedDevilledEgg>().GameDataObject;
        public static ItemGroup RedEgg => (ItemGroup)GDOUtils.GetCustomGameDataObject<RedEgg>().GameDataObject;
        public static ItemGroup RedRawEasterBread => (ItemGroup)GDOUtils.GetCustomGameDataObject<RedRawEasterBread>().GameDataObject;
        public static ItemGroup UnwrappedCremeEgg => (ItemGroup)GDOUtils.GetCustomGameDataObject<UnwrappedCremeEgg>().GameDataObject;

        #endregion

        #region Dish

        public static Dish DishCremeEgg => (Dish)GDOUtils.GetCustomGameDataObject<DishCremeEgg>().GameDataObject;
        public static Dish DishDevilledEggs => (Dish)GDOUtils.GetCustomGameDataObject<DishDevilledEggs>().GameDataObject;
        public static Dish DishDyedEggs => (Dish)GDOUtils.GetCustomGameDataObject<DishDyedEggs>().GameDataObject;
        public static Dish DishEasterBread => (Dish)GDOUtils.GetCustomGameDataObject<DishEasterBread>().GameDataObject;
        public static Dish DishHotCrossBun => (Dish)GDOUtils.GetCustomGameDataObject<DishHotCrossBun>().GameDataObject;
        public static Dish RecipeCremeFilling => (Dish)GDOUtils.GetCustomGameDataObject<RecipeCremeFilling>().GameDataObject;
        public static Dish RecipeMayonnaise => (Dish)GDOUtils.GetCustomGameDataObject<RecipeMayonnaise>().GameDataObject;

        #endregion

        #region Decor

        public static Decor EggWallpaper => (Decor)GDOUtils.GetCustomGameDataObject<EggWallpaper>().GameDataObject;

        #endregion

        #region Appliance

        public static Appliance DyeProvider => (Appliance)GDOUtils.GetCustomGameDataObject<DyeProvider>().GameDataObject;
        public static Appliance EggMouldProvider => (Appliance)GDOUtils.GetCustomGameDataObject<EggMouldProvider>().GameDataObject;
        public static Appliance HotCrossBunsProvider => (Appliance)GDOUtils.GetCustomGameDataObject<HotCrossBunsProvider>().GameDataObject;
        public static Appliance WrapperProvider => (Appliance)GDOUtils.GetCustomGameDataObject<WrapperProvider>().GameDataObject;
        public static Appliance EasterGround => (Appliance)GDOUtils.GetCustomGameDataObject<EasterGround>().GameDataObject;
        public static Appliance EggCobblestone => (Appliance)GDOUtils.GetCustomGameDataObject<EggCobblestone>().GameDataObject;
        public static Appliance EggPile => (Appliance)GDOUtils.GetCustomGameDataObject<EggPile>().GameDataObject;

        #endregion
    }
}