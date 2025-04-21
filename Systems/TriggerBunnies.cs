using Easter2025.Components;
using Kitchen;
using KitchenMods;
using Unity.Entities;
using UnityEngine;

namespace Easter2025.Systems
{
    public class TriggerBunnies : DaySystem, IModSystem
    {
        protected override void OnUpdate()
        {
            if (HasSingleton<SHasTriggeredBunnies>()) return;
            if (Input.GetKeyDown(KeyCode.F))
            {
                SpawnBunny(1, Mod.RED_BUNNY_VIEW);
                SpawnBunny(3, Mod.GREEN_BUNNY_VIEW);
                SpawnBunny(5 , Mod.BLUE_BUNNY_VIEW);
                EntityManager.CreateEntity(typeof(SHasTriggeredBunnies));
            }
        }

        private void SpawnBunny(int position, ViewType viewType)
        {
            Entity entity = EntityManager.CreateEntity(typeof(CPosition), typeof(CRequiresView));
            Set(entity, new CPosition(-0.5f, 0, position));
            Set(entity, new CRequiresView
            {
                Type = viewType,
                ViewMode = ViewMode.World
            });
        }
    }
}