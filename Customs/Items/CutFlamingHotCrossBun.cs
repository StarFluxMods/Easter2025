using System.Collections.Generic;
using Easter2025.Components;
using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using Easter2025.Views.Local;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;
using UnityEngine.VFX;

namespace Easter2025.Customs.Items
{
    public class CutFlamingHotCrossBun : GenericStackableItem
    {
        public override string UniqueNameID => "CutFlamingHotCrossBun";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CutFlamingHotCrossBun").AssignMaterialsByNames().AssignVFXByNames();
        // public override bool IsIndisposable => true;

        public override List<IItemProperty> Properties => new List<IItemProperty>
        {
            new CCanTriggerOrbs()
        };

        public override List<Item.ItemProcess> Processes => new()
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Clean,
                Duration = 1,
                Result = GDOReferences.CutBurnedHotCrossBun
            }
        };

        public override void OnRegister(Item gameDataObject)
        {
            base.OnRegister(gameDataObject);
            gameDataObject.Prefab.AddComponent<FlamingView>().Fire = gameDataObject.Prefab.GetComponentInChildren<VisualEffect>();
        }
    }
}