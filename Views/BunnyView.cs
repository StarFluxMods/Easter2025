using System;
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
    public class BunnyView : UpdatableObjectView<BunnyView.ViewData>
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
                return view.GetSubView<BunnyView>();
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
            GenericAnimator.SetBool("isJumping", true);
        }
    }
}