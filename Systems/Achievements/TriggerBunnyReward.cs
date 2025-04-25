using Easter2025.Components;
using Easter2025.Utilies;
using Kitchen;
using KitchenMods;
using Unity.Entities;

namespace Easter2025.Systems.Achievements
{
    public class TriggerBunnyReward : DaySystem, IModSystem
    {
        private readonly int REWARD_AMOUNT = 250;

        private EntityQuery _OrangeOrbs;
        protected override void Initialise()
        {
            base.Initialise();
            _OrangeOrbs = GetEntityQuery(new QueryHelper().All(typeof(CHasOrangeOrbs)));
        }

        protected override void OnUpdate()
        {
            if (HasSingleton<SHasTriggeredBunnies>()) return;
            if (_OrangeOrbs.IsEmpty) return;
            
            if (HasSingleton<CSetting>())
            {
                CSetting setting = GetSingleton<CSetting>();
                if (setting.RestaurantSetting != GDOReferences.Easter2025Setting.ID && setting.RestaurantSetting != GDOReferences.Easter2025GardenSetting.ID) return;
            }
            else
            {
                return;
            }

            SpawnBunny(1, Mod.RED_BUNNY_VIEW);
            SpawnBunny(3, Mod.GREEN_BUNNY_VIEW);
            SpawnBunny(5 , Mod.BLUE_BUNNY_VIEW);
                
            Entity e = EntityManager.CreateEntity(typeof(CMoneyTrackEvent));
            EntityManager.SetComponentData(e, new CMoneyTrackEvent
            {
                Identifier = GDOReferences.GenerousBunnies.ID,
                Amount = REWARD_AMOUNT
            });
                
            if (HasSingleton<SMoney>())
            {
                SMoney money = GetSingleton<SMoney>();
                money.Amount += REWARD_AMOUNT;
                SetSingleton(money);
            }
            Mod.achievementsManager.UnlockAchievement(Mod.ACHIEVEMENT_TRIGGER_BUNNIES);
                
            EntityManager.CreateEntity(typeof(SHasTriggeredBunnies));
        }

        private void SpawnBunny(int position, ViewType viewType)
        {
            Entity entity = EntityManager.CreateEntity(typeof(CPosition), typeof(CRequiresView), typeof(CEventBunny));
            Set(entity, new CPosition(-0.5f, 0, position));
            Set(entity, new CRequiresView
            {
                Type = viewType,
                ViewMode = ViewMode.World
            });
        }
    }
}