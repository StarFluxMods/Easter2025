using Kitchen;
using KitchenMods;
using MessagePack;
using UnityEngine;

namespace Easter2025.Views
{
    public class BunnyEasterEggView : UpdatableObjectView<BunnyEasterEggView.ViewData>
    {
        public class UpdateView : IncrementalViewSystemBase<ViewData>, IModSystem
        {
            protected override void OnUpdate()
            {
            }
        }
        
        [MessagePackObject(false)]
        public class ViewData : ISpecificViewData, IViewData.ICheckForChanges<ViewData>
        {
            public IUpdatableObject GetRelevantSubview(IObjectView view)
            {
                return view.GetSubView<BunnyEasterEggView>();
            }

            public bool IsChangedFrom(ViewData check)
            {
                return true;
            }
        }
        
        protected override void UpdateData(ViewData viewData)
        {

        }
        
        public Animator GenericAnimator;

        private void Update()
        {
            if (GenericAnimator == null) return;
            GenericAnimator.SetBool("isLookingOut", true);
        }
    }
}