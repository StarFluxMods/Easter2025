using KitchenData;
using KitchenLib.Customs;

namespace Easter2025.Customs.Generics
{
    public abstract class GenericStackableItemGroup : CustomItemGroup
    {
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
    }
}