using KitchenData;
using KitchenLib.Customs;

namespace Easter2025.Customs.Generics
{
    public abstract class GenericStackableItem : CustomItem
    {
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
    }
}