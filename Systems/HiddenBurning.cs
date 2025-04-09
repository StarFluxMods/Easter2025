using System;
using Easter2025.Components;
using Kitchen;
using KitchenMods;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Easter2025.Systems
{
    public class HiddenBurning : RestaurantSystem, IModSystem
    {
        private EntityQuery _HiddenBurnables;
        protected override void Initialise()
        {
            base.Initialise();
            _HiddenBurnables = GetEntityQuery(new QueryHelper().All(typeof(CHiddenBurnProcess), typeof(CItem)));
        }

        protected override void OnUpdate()
        {
            using (NativeArray<Entity> hiddenBurnables = _HiddenBurnables.ToEntityArray(Allocator.Temp))
            {
                for (var i = 0; i < hiddenBurnables.Length; i++)
                {
                    var hiddenBurnable = hiddenBurnables[i];
                    if (!Require(hiddenBurnable, out CHiddenBurnProcess cHiddenBurnProcess)) continue;
                    if (cHiddenBurnProcess.BurnableSurfaces.Length == 0) continue;
                    if (cHiddenBurnProcess.Result.Length == 0) continue;
                    if (cHiddenBurnProcess.IsComplete) continue;
                    
                    if (Require(hiddenBurnable, out CHeldBy cHeldBy))
                    {
                        if (Require(cHeldBy.Holder, out CAppliance cAppliance))
                        {
                            if (cHiddenBurnProcess.BurnableSurfaces.Contains(cAppliance.ID))
                            {
                                if (cHiddenBurnProcess.BurnProgress >= 1)
                                {
                                    Set(hiddenBurnable, new CChangeItemType
                                    {
                                        NewID = cHiddenBurnProcess.Result[Random.Range(0, cHiddenBurnProcess.Result.Length)]
                                    });
                                    cHiddenBurnProcess.IsComplete = true;
                                    Set(hiddenBurnable, cHiddenBurnProcess);
                                }
                                else
                                {
                                    cHiddenBurnProcess.BurnProgress = Mathf.Clamp01(cHiddenBurnProcess.BurnProgress + (Time.DeltaTime * (1 / cHiddenBurnProcess.BurnTimeInSeconds)));
                                    Set(hiddenBurnable, cHiddenBurnProcess);
                                }
                                continue;
                            }
                        }
                    }
                    
                    cHiddenBurnProcess.BurnProgress = 0;
                    Set(hiddenBurnable, cHiddenBurnProcess);
                }
            }
        }
    }
}