using KitchenData;
using KitchenLib.Customs;

namespace Easter2025.Customs.Generics
{
    public abstract class GenericDecorationAppliance : CustomAppliance
    {
        public override bool IsPurchasable => false;
        public override ShoppingTags ShoppingTags => ShoppingTags.Decoration;
        public override PriceTier PriceTier => PriceTier.Free;
    }
}