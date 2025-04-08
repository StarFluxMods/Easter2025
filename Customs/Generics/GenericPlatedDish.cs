using Easter2025.Utilies;
using KitchenData;
using KitchenLib.Customs;

namespace Easter2025.Customs.Generics
{
    public abstract class GenericPlatedDish : CustomItemGroup
    {
        public override Item DisposesTo => GDOReferences.Plate;
        public override Item DirtiesTo => GDOReferences.PlateDirty;
        public override bool CanContainSide => true;
    }
}