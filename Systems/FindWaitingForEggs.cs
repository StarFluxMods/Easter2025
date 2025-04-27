using Easter2025.Components;
using Kitchen;
using KitchenMods;
using Unity.Collections;
using Unity.Entities;

namespace Easter2025.Systems
{
    public class FindWaitingForEggs : GameSystemBase, IModSystem
    {
        private EntityQuery _waitingForEggsQuery;

        protected override void Initialise()
        {
            base.Initialise();
            _waitingForEggsQuery = GetEntityQuery(typeof(CWaitingForItem), typeof(CPatience));
        }

        protected override void OnUpdate()
        {
            using NativeArray<Entity> waitingForEggs = _waitingForEggsQuery.ToEntityArray(Allocator.Temp);
            foreach (Entity entity in waitingForEggs)
            {
                DynamicBuffer<CWaitingForItem> waitingForItemBuffer = EntityManager.GetBuffer<CWaitingForItem>(entity);
                if (!Require(entity, out CPatience cPatience)) continue;
                if ((cPatience.StartTime > 0f ? cPatience.RemainingTime : 1f) > 0.5f) continue;
                foreach (CWaitingForItem waitingForItem in waitingForItemBuffer)
                {
                    if (EntityManager.HasComponent<CHidableItem>(waitingForItem.Item))
                    {
                        EntityManager.AddComponent<CShouldShakeBushes>(entity);
                    }
                }
            }
        }
    }
}