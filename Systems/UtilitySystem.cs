using Kitchen;
using KitchenMods;
using Unity.Entities;

namespace Easter2025.Systems
{
    public class UtilitySystem : GameSystemBase, IModSystem
    {
        private static UtilitySystem Instance;
        protected override void Initialise()
        {
            base.Initialise();
            Instance = this;
        }

        protected override void OnUpdate()
        {
        }
        
        public static bool _Has<T>(Entity entity) where T : struct, IComponentData
        {
            return Instance.Has<T>(entity);
        }
        
        public static bool _Require<T>(Entity entity, out T result) where T : struct, IComponentData
        {
            return Instance.Require<T>(entity, out result);
        }
        
        public static void _Set<T>(Entity entity, T componentData) where T : struct, IComponentData
        {
            Instance.Set<T>(entity, componentData);
        }
    }
}