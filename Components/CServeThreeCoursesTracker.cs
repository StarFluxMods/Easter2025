using KitchenMods;
using Unity.Entities;

namespace Easter2025.Components
{
    public struct CServeThreeCoursesTracker : IComponentData, IModComponent
    {
        public bool HasHadEggStarter;
        public bool HasHadEggMain;
        public bool HasHadEggDessert;
    }
}