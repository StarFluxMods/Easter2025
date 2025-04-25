using Easter2025.Components;
using Kitchen;
using KitchenMods;
using Unity.Entities;

namespace Easter2025.Systems
{
    public class SpawnRoamingBunnies : StartOfDaySystem, IModSystem
    {
        protected override void OnUpdate()
        {
            if (!HasSingleton<SHasTriggeredBunnies>()) return;
            SpawnBunny(-5, Mod.ROAMING_RED_BUNNY_VIEW);
            SpawnBunny(-6, Mod.ROAMING_GREEN_BUNNY_VIEW);
            SpawnBunny(-7, Mod.ROAMING_BLUE_BUNNY_VIEW);
        }

        private void SpawnBunny(int position, ViewType viewType)
        {
            Entity entity = EntityManager.CreateEntity(typeof(CPosition), typeof(CRequiresView), typeof(CBunny));
            Set(entity, new CPosition(-0.5f, 0, position));
            Set(entity, new CRequiresView
            {
                Type = viewType,
                ViewMode = ViewMode.World,
                PhysicsDriven = true
            });
        }
    }
}