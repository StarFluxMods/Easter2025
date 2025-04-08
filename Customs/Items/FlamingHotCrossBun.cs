using System.Collections.Generic;
using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using Easter2025.Views.Local;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;
using UnityEngine.VFX;

namespace Easter2025.Customs.Items
{
    public class FlamingHotCrossBun : GenericStackableItem
    {
        public override string UniqueNameID => "FlamingHotCrossBun";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("FlamingHotCrossBun").AssignMaterialsByNames().AssignVFXByNames();
        public override bool IsIndisposable => true;

        public override List<Item.ItemProcess> Processes => new()
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Chop,
                Duration = 1,
                Result = GDOReferences.CutFlamingHotCrossBun
            },
            new Item.ItemProcess
            {
                Process = GDOReferences.Clean,
                Duration = 1,
                Result = GDOReferences.BurnedHotCrossBun
            }
        };

        public override void OnRegister(Item gameDataObject)
        {
            base.OnRegister(gameDataObject);
            gameDataObject.Prefab.AddComponent<FlamingView>().Fire = gameDataObject.Prefab.GetComponentInChildren<VisualEffect>();
        }
    }
}