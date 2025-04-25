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
    public class BushView : UpdatableObjectView<BushView.ViewData>
    {
        public class UpdateView : IncrementalViewSystemBase<ViewData>, IModSystem
        {
            private EntityQuery Views;
            private EntityQuery _ShouldShake;

            protected override void Initialise()
            {
                base.Initialise();

                Views = GetEntityQuery(new QueryHelper().All(typeof(CEggBush), typeof(CLinkedView)));
                _ShouldShake = GetEntityQuery(typeof(CShouldShakeBushes));
            }

            protected override void OnUpdate()
            {
                using var entities = Views.ToEntityArray(Allocator.Temp);
                using var views = Views.ToComponentDataArray<CLinkedView>(Allocator.Temp);

                for (var i = 0; i < views.Length; i++)
                {
                    var entity = entities[i];
                    var view = views[i];
                    if (Require(entity, out CCanHideItem cCanHideItem))
                    {
                        SendUpdate(view, new ViewData
                        {
                            ShouldShake = !_ShouldShake.IsEmpty && cCanHideItem.HiddenItem != 0
                        });
                    }
                }
            }
        }

        [MessagePackObject(false)]
        public struct ViewData : ISpecificViewData, IViewData.ICheckForChanges<ViewData>
        {
            [Key(0)] public bool ShouldShake;

            public IUpdatableObject GetRelevantSubview(IObjectView view) => view.GetSubView<BushView>();

            public bool IsChangedFrom(ViewData cached)
            {
                return ShouldShake != cached.ShouldShake;
            }
        }

        public Animator Animator;
        
        protected override void UpdateData(ViewData view_data)
        {
            Animator.SetBool("IsShaking", view_data.ShouldShake);
        }
    }
}