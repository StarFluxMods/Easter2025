using Easter2025.Components;
using Kitchen;
using KitchenLib.References;
using KitchenMods;
using MessagePack;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace Easter2025.Views
{
    public class BinOrbView : UpdatableObjectView<BinOrbView.ViewData>
    {
        public class UpdateView : IncrementalViewSystemBase<ViewData>, IModSystem
        {
            private EntityQuery Views;

            protected override void Initialise()
            {
                base.Initialise();

                Views = GetEntityQuery(new QueryHelper().All(typeof(CAppliance), typeof(CApplianceBin), typeof(CLinkedView)));
            }

            protected override void OnUpdate()
            {
                using var entities = Views.ToEntityArray(Allocator.Temp);
                using var views = Views.ToComponentDataArray<CLinkedView>(Allocator.Temp);

                for (var i = 0; i < views.Length; i++)
                {
                    var view = views[i];
                    var entity = entities[i];

                    if (!Require(entity, out CAppliance cAppliance)) continue;
                    if (cAppliance.ID != ApplianceReferences.Bin) continue;
                    
                    SendUpdate(view, new ViewData
                    {
                        ShouldShowOrbs = Has<CHasOrbs>(entity)
                    });
                }
            }
        }

        [MessagePackObject(false)]
        public struct ViewData : ISpecificViewData, IViewData.ICheckForChanges<ViewData>
        {
            [Key(0)] public bool ShouldShowOrbs;

            public IUpdatableObject GetRelevantSubview(IObjectView view) => view.GetSubView<BinOrbView>();

            public bool IsChangedFrom(ViewData cached)
            {
                return ShouldShowOrbs != cached.ShouldShowOrbs;
            }
        }

        public GameObject OrbContainer;

        protected override void UpdateData(ViewData view_data)
        {
            OrbContainer.SetActive(view_data.ShouldShowOrbs);
        }
    }
}