using KitchenMods;
using Unity.Entities;

namespace Easter2025.Components
{
    public struct SHasTriggeredBunnies : IComponentData, IModComponent
    {
        public struct RewardMarker : IComponentData, IModComponent
        {
        }
    }
}