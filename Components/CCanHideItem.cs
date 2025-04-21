using KitchenData;
using KitchenMods;
using Unity.Entities;

namespace Easter2025.Components
{
    public struct CCanHideItem : IComponentData, IModComponent, IApplianceProperty
    {
        public int HiddenItem;
    }
}