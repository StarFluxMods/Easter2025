using System;
using Easter2025.Components;
using Kitchen;
using KitchenMods;
using MessagePack;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;
using UnityEngine.AI;

namespace Easter2025.Views
{
    public class RoamingBunnyView : UpdatableObjectView<RoamingBunnyView.ViewData>
    {
        public NavMeshAgent agent;
        public Animator animator;
        
        public override void SetPosition(UpdateViewPositionData pos)
        {
            if (!pos.Force && !((transform.localPosition - pos.Position).Chebyshev() > 0.5f)) return;
            base.SetPosition(pos);
            agent.Warp(pos.Position);
        }
        
        protected override void UpdatePosition() { }
        
        public class UpdateView : IncrementalViewSystemBase<ViewData>, IModSystem
        {
            private EntityQuery _Bunnies;

            protected override void Initialise()
            {
                base.Initialise();
                _Bunnies = GetEntityQuery(typeof(CLinkedView), typeof(CBunny));
            }

            protected override void OnUpdate()
            {
                using (NativeArray<Entity> Bunnies = _Bunnies.ToEntityArray(Allocator.Temp))
                {
                    foreach (Entity Bunny in Bunnies)
                    {
                        if (!Require(Bunny, out CLinkedView cLinkedView) || !Has<CBunny>(Bunny)) continue;

                        Vector3 TargetPosition = Vector3.zero;
                        Vector3 PreferedFacingDirection = Vector3.zero;
                        float StopDistance = 0;
                        bool ShouldMove = false;
                    
                        if (Require(Bunny, out CMoveToLocation cMoveToLocation))
                        {
                            TargetPosition = cMoveToLocation.Location;
                            PreferedFacingDirection = cMoveToLocation.DesiredFacing;
                            StopDistance = cMoveToLocation.StoppingDistance;
                            ShouldMove = true;
                        }
                    

                        SendUpdate(cLinkedView, new ViewData
                        {
                            TargetPosition = TargetPosition,
                            StopDistance = StopDistance,
                            IsMoving = ShouldMove,
                            PreferedFacingDirection = PreferedFacingDirection
                        });
                    }
                }

                
            }
        }
        
        [MessagePackObject(false)]
        public class ViewData : ISpecificViewData, IViewData.ICheckForChanges<ViewData>
        {
            public IUpdatableObject GetRelevantSubview(IObjectView view)
            {
                return view.GetSubView<RoamingBunnyView>();
            }

            public bool IsChangedFrom(ViewData check)
            {
                return true;
            }

            [Key(0)] public bool IsMoving;
            [Key(1)] public Vector3 TargetPosition;
            [Key(2)] public float StopDistance;
            [Key(3)] public Vector3 PreferedFacingDirection;
        }

        private ViewData Data;
        
        protected override void UpdateData(ViewData viewData)
        {
            Data = viewData;
        }
        
        private void Update()
        {
            if (Data == null) return;

            if (agent != null)
            {
                if (Data.TargetPosition != Vector3.zero && Data.IsMoving)
                {
                    agent.stoppingDistance = Data.StopDistance;
                    agent.SetDestination(Data.TargetPosition);
                }
                
                if (agent.remainingDistance <= agent.stoppingDistance && Data.PreferedFacingDirection != Vector3.zero)
                {
                    transform.rotation = Quaternion.LookRotation(Data.PreferedFacingDirection - transform.position, Vector3.up);
                }

                if (agent.velocity.magnitude > 0.1f)
                {
                    animator.SetBool("isJumping", true);
                    animator.SetFloat("Speed", agent.velocity.magnitude);
                }
                else
                {
                    animator.SetBool("isJumping", false);
                    animator.SetBool("isRunning", false);
                }
            }
        }
    }
}