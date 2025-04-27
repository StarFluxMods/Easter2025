using System.Collections.Generic;
using System.Linq;
using Kitchen;
using KitchenLib.UI;
using KitchenMods;
using Unity.Entities;
using UnityEngine;

namespace Easter2025.Systems
{
    public class ConflictWarning : FranchiseFirstFrameSystem, IModSystem
    {
        private EntityQuery _ConflictWarningSingleton;
        private List<ulong> _ConflictingMods = new List<ulong>
        {
            2957324159,
            3210372194
        };
        
        protected override void Initialise()
        {
            base.Initialise();
            _ConflictWarningSingleton = GetEntityQuery(typeof(SConflictWarning));
        }
        
        protected override void OnUpdate()
        {
            if (!_ConflictWarningSingleton.IsEmpty) return;

            List<string> ConflictWarningList = (from mod in ModPreload.Mods where _ConflictingMods.Contains(mod.ID) select mod.Name).ToList();

            if (ConflictWarningList.Count > 0)
            {
                string conflictList = "";
                foreach (string conflictWarning in ConflictWarningList)
                {
                    conflictList += " - " + conflictWarning + "\n";
                }

                GenericPopupManager.CreatePopup(
                    "Mod Conflict",
                    $"One or more of your mods are conflicting with {Mod.MOD_NAME}\n\n{conflictList}\nContinue to close your game, or cancel to ignore this warning.",
                    GenericChoiceType.AcceptOrConsentCancel,
                    () => { Application.Quit();},
                    null,
                    TMPro.TextAlignmentOptions.Center
                );
            }

            EntityManager.CreateEntity(typeof(SConflictWarning), typeof(CPersistThroughSceneChanges), typeof(CDoNotPersist));
        }
        
        public struct SConflictWarning : IComponentData, IModComponent
        {
        }
    }
}