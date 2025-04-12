using Easter2025.Customs.Appliances;
using Easter2025.Customs.Dishes;
using Easter2025.Customs.ItemGroups;
using Easter2025.Customs.Items;
using KitchenData;
using KitchenLib.References;
using KitchenLib.Utils;

namespace Easter2025.Utilies
{
    public class GDOReferences
    {
        #region Vanilla

        #region Item

        public static Item Plate => (Item)GDOUtils.GetExistingGDO(ItemReferences.Plate);
        public static Item PlateDirty => (Item)GDOUtils.GetExistingGDO(ItemReferences.PlateDirty);
        public static Item Butter => (Item)GDOUtils.GetExistingGDO(ItemReferences.Butter);
        public static Item Egg => (Item)GDOUtils.GetExistingGDO(ItemReferences.Egg);
        public static Item Pot => (Item)GDOUtils.GetExistingGDO(ItemReferences.Pot);
        public static Item Water => (Item)GDOUtils.GetExistingGDO(ItemReferences.Water);
        public static Item Oil => (Item)GDOUtils.GetExistingGDO(ItemReferences.Oil);
        public static Item Dough => (Item)GDOUtils.GetExistingGDO(ItemReferences.Dough);
        public static Item Flour => (Item)GDOUtils.GetExistingGDO(ItemReferences.Flour);

        #endregion

        #region ItemGroup

        public static ItemGroup Mayonnaise => (ItemGroup)GDOUtils.GetExistingGDO(ItemGroupReferences.Mayonnaise);

        #endregion

        #region Process

        public static Process Chop => (Process)GDOUtils.GetExistingGDO(ProcessReferences.Chop);
        public static Process Cook => (Process)GDOUtils.GetExistingGDO(ProcessReferences.Cook);
        public static Process Clean => (Process)GDOUtils.GetExistingGDO(ProcessReferences.Clean);

        #endregion

        #endregion
        
        #region Item
public static Item BlueDye => (Item)GDOUtils.GetCustomGameDataObject<BlueDye>().GameDataObject;
public static Item MixedEggYolk => (Item)GDOUtils.GetCustomGameDataObject<MixedEggYolk>().GameDataObject;
public static Item SlicedEgg => (Item)GDOUtils.GetCustomGameDataObject<SlicedEgg>().GameDataObject;
public static Item RedSlicedEgg => (Item)GDOUtils.GetCustomGameDataObject<RedSlicedEgg>().GameDataObject;
public static Item GreenSlicedEgg => (Item)GDOUtils.GetCustomGameDataObject<GreenSlicedEgg>().GameDataObject;
public static Item BlueSlicedEgg => (Item)GDOUtils.GetCustomGameDataObject<BlueSlicedEgg>().GameDataObject;
public static Item DeYolkedSlicedEgg => (Item)GDOUtils.GetCustomGameDataObject<DeYolkedSlicedEgg>().GameDataObject;
public static Item RedDeYolkedSlicedEgg => (Item)GDOUtils.GetCustomGameDataObject<RedDeYolkedSlicedEgg>().GameDataObject;
public static Item GreenDeYolkedSlicedEgg => (Item)GDOUtils.GetCustomGameDataObject<GreenDeYolkedSlicedEgg>().GameDataObject;
public static Item BlueDeYolkedSlicedEgg => (Item)GDOUtils.GetCustomGameDataObject<BlueDeYolkedSlicedEgg>().GameDataObject;
public static Item EggYolk => (Item)GDOUtils.GetCustomGameDataObject<EggYolk>().GameDataObject;
public static Item BlueShell => (Item)GDOUtils.GetCustomGameDataObject<BlueShell>().GameDataObject;
public static Item BoiledEgg => (Item)GDOUtils.GetCustomGameDataObject<BoiledEgg>().GameDataObject;
public static Item BoiledEggPot => (Item)GDOUtils.GetCustomGameDataObject<BoiledEggPot>().GameDataObject;
public static Item BurnedHotCrossBun => (Item)GDOUtils.GetCustomGameDataObject<BurnedHotCrossBun>().GameDataObject;
public static Item CookedHotCrossBun => (Item)GDOUtils.GetCustomGameDataObject<CookedHotCrossBun>().GameDataObject;
public static Item CutBurnedHotCrossBun => (Item)GDOUtils.GetCustomGameDataObject<CutBurnedHotCrossBun>().GameDataObject;
public static Item CutCookedHotCrossBun => (Item)GDOUtils.GetCustomGameDataObject<CutCookedHotCrossBun>().GameDataObject;
public static Item CutFlamingHotCrossBun => (Item)GDOUtils.GetCustomGameDataObject<CutFlamingHotCrossBun>().GameDataObject;
public static Item CutRawHotCrossBun => (Item)GDOUtils.GetCustomGameDataObject<CutRawHotCrossBun>().GameDataObject;
public static Item FlamingHotCrossBun => (Item)GDOUtils.GetCustomGameDataObject<FlamingHotCrossBun>().GameDataObject;
public static Item GreenDye => (Item)GDOUtils.GetCustomGameDataObject<GreenDye>().GameDataObject;
public static Item GreenShell => (Item)GDOUtils.GetCustomGameDataObject<GreenShell>().GameDataObject;
public static Item RawHotCrossBun => (Item)GDOUtils.GetCustomGameDataObject<RawHotCrossBun>().GameDataObject;
public static Item RedDye => (Item)GDOUtils.GetCustomGameDataObject<RedDye>().GameDataObject;
public static Item RedShell => (Item)GDOUtils.GetCustomGameDataObject<RedShell>().GameDataObject;
public static Item EasterBread => (Item)GDOUtils.GetCustomGameDataObject<EasterBread>().GameDataObject;
public static Item RedEasterBread => (Item)GDOUtils.GetCustomGameDataObject<RedEasterBread>().GameDataObject;
public static Item GreenEasterBread => (Item)GDOUtils.GetCustomGameDataObject<GreenEasterBread>().GameDataObject;
public static Item BlueEasterBread => (Item)GDOUtils.GetCustomGameDataObject<BlueEasterBread>().GameDataObject;
#endregion

#region ItemGroup
public static ItemGroup HotCrossBun => (ItemGroup)GDOUtils.GetCustomGameDataObject<HotCrossBun>().GameDataObject;
public static ItemGroup RawEggPot => (ItemGroup)GDOUtils.GetCustomGameDataObject<RawEggPot>().GameDataObject;
public static ItemGroup RedEgg => (ItemGroup)GDOUtils.GetCustomGameDataObject<RedEgg>().GameDataObject;
public static ItemGroup GreenEgg => (ItemGroup)GDOUtils.GetCustomGameDataObject<GreenEgg>().GameDataObject;
public static ItemGroup BlueEgg => (ItemGroup)GDOUtils.GetCustomGameDataObject<BlueEgg>().GameDataObject;
public static ItemGroup DevilledEgg => (ItemGroup)GDOUtils.GetCustomGameDataObject<DevilledEgg>().GameDataObject;
public static ItemGroup RedDevilledEgg => (ItemGroup)GDOUtils.GetCustomGameDataObject<RedDevilledEgg>().GameDataObject;
public static ItemGroup GreenDevilledEgg => (ItemGroup)GDOUtils.GetCustomGameDataObject<GreenDevilledEgg>().GameDataObject;
public static ItemGroup BlueDevilledEgg => (ItemGroup)GDOUtils.GetCustomGameDataObject<BlueDevilledEgg>().GameDataObject;
public static Dish RecipeMayonnaise => (Dish)GDOUtils.GetCustomGameDataObject<RecipeMayonnaise>().GameDataObject;
#endregion

#region Appliance
public static Appliance DyeProvider => (Appliance)GDOUtils.GetCustomGameDataObject<DyeProvider>().GameDataObject;
public static Appliance HotCrossBunsProvider => (Appliance)GDOUtils.GetCustomGameDataObject<HotCrossBunsProvider>().GameDataObject;
public static Dish DishDyedEggs => (Dish)GDOUtils.GetCustomGameDataObject<DishDyedEggs>().GameDataObject;
#endregion


    }
}