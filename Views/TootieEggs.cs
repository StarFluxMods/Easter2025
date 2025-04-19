using Easter2025.Components;
using Easter2025.Customs.ItemGroups;
using Kitchen;
using KitchenLib.References;
using KitchenLib.Utils;
using KitchenMods;
using MessagePack;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace Easter2025.Views
{
    public class TootieEggs : UpdatableObjectView<TootieEggs.ViewData>
    {
        public class UpdateView : IncrementalViewSystemBase<ViewData>, IModSystem
        {
            private EntityQuery Views;

            protected override void Initialise()
            {
                base.Initialise();

                Views = GetEntityQuery(new QueryHelper().All(typeof(CItem), typeof(CLinkedView)));
            }

            protected override void OnUpdate()
            {
                using var entities = Views.ToEntityArray(Allocator.Temp);
                using var views = Views.ToComponentDataArray<CLinkedView>(Allocator.Temp);

                for (var i = 0; i < views.Length; i++)
                {
                    var view = views[i];
                    var entity = entities[i];

                    if (!Require(entity, out CItem cItem)) continue;
                    if (cItem.ID != GDOUtils.GetCustomGameDataObject<RedEgg>().ID && cItem.ID != GDOUtils.GetCustomGameDataObject<GreenEgg>().ID && cItem.ID != GDOUtils.GetCustomGameDataObject<BlueEgg>().ID) continue;
                    
                    SendUpdate(view, new ViewData
                    {
                        ShouldTootify = Utilies.Utility.IsTootieInLobby()
                    });
                }
            }
        }

        [MessagePackObject(false)]
        public struct ViewData : ISpecificViewData, IViewData.ICheckForChanges<ViewData>
        {
            [Key(0)] public bool ShouldTootify;

            public IUpdatableObject GetRelevantSubview(IObjectView view) => view.GetSubView<TootieEggs>();

            public bool IsChangedFrom(ViewData cached)
            {
                return ShouldTootify != cached.ShouldTootify;
            }
        }

        public GameObject TootieEgg;
        public GameObject NormalEgg;

        protected override void UpdateData(ViewData view_data)
        {
            TootieEgg.SetActive(view_data.ShouldTootify);
            NormalEgg.SetActive(!view_data.ShouldTootify);
        }
    }
}