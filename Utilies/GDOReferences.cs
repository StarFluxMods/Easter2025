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

        #endregion
        
        #endregion
    }
}