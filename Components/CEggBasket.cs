using KitchenData;
using KitchenMods;
using Unity.Entities;

namespace Easter2025.Components
{
    public struct CEggBasket : IComponentData, IModComponent, IItemProperty
    {
        public struct CanPlaceInBasket : IComponentData, IModComponent, IItemProperty
        {
        }
    }
}