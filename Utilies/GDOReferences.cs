using Easter2025.Customs.Appliances;
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

        #endregion

        #region Process
        
        public static Process Chop => (Process)GDOUtils.GetExistingGDO(ProcessReferences.Chop);
        public static Process Cook => (Process)GDOUtils.GetExistingGDO(ProcessReferences.Cook);

        #endregion
        
        #endregion
        
        #region Item
        public static Item CookedHotCrossBun => (Item)GDOUtils.GetCustomGameDataObject<CookedHotCrossBun>().GameDataObject;
        public static Item CutCookedHotCrossBun => (Item)GDOUtils.GetCustomGameDataObject<CutCookedHotCrossBun>().GameDataObject;
        public static Item CutRawHotCrossBun => (Item)GDOUtils.GetCustomGameDataObject<CutRawHotCrossBun>().GameDataObject;
        public static Item RawHotCrossBun => (Item)GDOUtils.GetCustomGameDataObject<RawHotCrossBun>().GameDataObject;
        #endregion

        #region ItemGroup
        public static ItemGroup HotCrossBun => (ItemGroup)GDOUtils.GetCustomGameDataObject<HotCrossBun>().GameDataObject;
        #endregion

        #region Appliance
        public static Appliance HotCrossBunsProvider => (Appliance)GDOUtils.GetCustomGameDataObject<HotCrossBunsProvider>().GameDataObject;
        #endregion
    }
}