using System;
using System.Collections.Generic;
using KitchenData;
using KitchenMods;
using Steamworks;
using Unity.Collections;
using Unity.Entities;

namespace Easter2025.Components
{
    public struct CHiddenBurnProcess : IComponentData, IModComponent, IItemProperty
    {
        public float BurnProgress;
        public float BurnTimeInSeconds;
        public FixedListInt64 Result;
        public bool IsComplete;
        public FixedListInt64 BurnableSurfaces;
    }
}