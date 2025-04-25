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
                        ShouldShowGreenOrbs = Has<CHasOrbs>(entity) && !Has<CHasOrangeOrbs>(entity),
                        ShouldShowOrangeOrbs = Has<CHasOrbs>(entity) && Has<CHasOrangeOrbs>(entity)
                    });
                }
            }
        }

        [MessagePackObject(false)]
        public struct ViewData : ISpecificViewData, IViewData.ICheckForChanges<ViewData>
        {
            [Key(0)] public bool ShouldShowGreenOrbs;
            [Key(2)] public bool ShouldShowOrangeOrbs;

            public IUpdatableObject GetRelevantSubview(IObjectView view) => view.GetSubView<BinOrbView>();

            public bool IsChangedFrom(ViewData cached)
            {
                return ShouldShowGreenOrbs != cached.ShouldShowGreenOrbs || ShouldShowOrangeOrbs != cached.ShouldShowOrangeOrbs;
            }
        }

        public GameObject GreenOrbs;
        public GameObject OrangeOrbs;

        protected override void UpdateData(ViewData view_data)
        {
            GreenOrbs.SetActive(view_data.ShouldShowGreenOrbs);
            OrangeOrbs.SetActive(view_data.ShouldShowOrangeOrbs);
        }
    }
}