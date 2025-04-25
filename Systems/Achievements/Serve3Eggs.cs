using Easter2025.Components;
using Easter2025.Utilies;
using Kitchen;
using KitchenMods;
using Unity.Collections;
using Unity.Entities;

namespace Easter2025.Systems.Achievements
{
    public class Serve3Eggs : RestaurantSystem, IModSystem
    {
        private EntityQuery _WaitingForItems;
        private EntityQuery _Trackers;

        protected override void Initialise()
        {
            base.Initialise();
            _WaitingForItems = GetEntityQuery(new QueryHelper().All(typeof(CWaitingForItem)));
            _Trackers = GetEntityQuery(new QueryHelper().All(typeof(CServeThreeCoursesTracker)).None(typeof(CCompletedAchievementEntity)));
        }

        protected override void OnUpdate()
        {
            using (NativeArray<Entity> WaitingForItems = _WaitingForItems.ToEntityArray(Allocator.Temp))
            {
                foreach (Entity WaitingForItem in WaitingForItems)
                {
                    if (!RequireBuffer(WaitingForItem, out DynamicBuffer<CWaitingForItem> cWaitingForItemBuffer)) continue;
                    if (!RequireBuffer(WaitingForItem, out DynamicBuffer<CGroupMember> cGroupMemberBuffer)) continue;
                    foreach (var cWaitingForItem in cWaitingForItemBuffer)
                    {
                        if (cWaitingForItem.Satisfied)
                        {
                            CGroupMember member = cGroupMemberBuffer[cWaitingForItem.MemberIndex];
                            if (cWaitingForItem.ItemID == GDOReferences.PinkPlasticEgg.ID || cWaitingForItem.ItemID == GDOReferences.YellowPlasticEgg.ID || cWaitingForItem.ItemID == GDOReferences.OrangePlasticEgg.ID)
                            {
                                SetStarterComplete(member.Customer);
                            }
                            else if (cWaitingForItem.ItemID == GDOReferences.RedEgg.ID || cWaitingForItem.ItemID == GDOReferences.GreenEgg.ID || cWaitingForItem.ItemID == GDOReferences.BlueEgg.ID)
                            {
                                SetMainComplete(member.Customer);
                            }
                            else if (cWaitingForItem.ItemID == GDOReferences.WrappedCremeEgg.ID)
                            {
                                SetDessertComplete(member.Customer);
                            }
                        }

                    }
                }
            }

            using (NativeArray<Entity> Trackers = _Trackers.ToEntityArray(Allocator.Temp))
            {
                foreach (Entity Tracker in Trackers)
                {
                    if (Require(Tracker, out CServeThreeCoursesTracker cServeThreeCoursesTracker))
                    {
                        if (cServeThreeCoursesTracker.HasHadEggStarter && cServeThreeCoursesTracker.HasHadEggMain && cServeThreeCoursesTracker.HasHadEggDessert)
                        {
                            Set<CCompletedAchievementEntity>(Tracker);
                            Mod.achievementsManager.UnlockAchievement(Mod.ACHIEVEMENT_SERVE_THREE_COURSE_EGGS);
                            return;
                        }
                    }
                }
            }
        }

        private void SetStarterComplete(Entity customer)
        {
            EnsureTracker(customer);
            if (Require(customer, out CServeThreeCoursesTracker cServeThreeCoursesTracker))
            {
                cServeThreeCoursesTracker.HasHadEggStarter = true;
                Set(customer, cServeThreeCoursesTracker);
            }
        }
        
        private void SetMainComplete(Entity customer)
        {
            EnsureTracker(customer);
            if (Require(customer, out CServeThreeCoursesTracker cServeThreeCoursesTracker))
            {
                cServeThreeCoursesTracker.HasHadEggMain = true;
                Set(customer, cServeThreeCoursesTracker);
            }
        }
        
        private void SetDessertComplete(Entity customer)
        {
            EnsureTracker(customer);
            if (Require(customer, out CServeThreeCoursesTracker cServeThreeCoursesTracker))
            {
                cServeThreeCoursesTracker.HasHadEggDessert = true;
                Set(customer, cServeThreeCoursesTracker);
            }
        }

        private void EnsureTracker(Entity customer)
        {
            if (!Has<CServeThreeCoursesTracker>(customer))
            {
                Set<CServeThreeCoursesTracker>(customer);
            }
        }
    }
}