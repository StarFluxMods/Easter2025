using Easter2025.Components;
using Kitchen;
using KitchenMods;
using Unity.Entities;

namespace Easter2025.Systems
{
    public class KillRoamingBunnies : StartOfNightSystem, IModSystem
    {
        private EntityQuery _Bunnies;
        private EntityQuery _EventBunnies;
        protected override void Initialise()
        {
            base.Initialise();
            _Bunnies = GetEntityQuery(typeof(CBunny));
            _EventBunnies = GetEntityQuery(typeof(CEventBunny));
        }

        protected override void OnUpdate()
        {
            EntityManager.DestroyEntity(_Bunnies);
            EntityManager.DestroyEntity(_EventBunnies);
        }
    }
}