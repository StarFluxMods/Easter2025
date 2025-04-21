using System.Collections.Generic;
using Easter2025.Components;
using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using Easter2025.Views.Local;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using Shapes;
using UnityEngine;

namespace Easter2025.Customs.Appliances.SceneAppliances
{
    public class Bush : GenericSceneAppliance
    {
        public override string UniqueNameID => "Bush";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Bush").AssignMaterialsByNames();
        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>
        {
            new CEggBush(),
            new CCanHideItem(),
            new CItemHolder(),
            new CImmovable(),
            new CTakesDuration
            {
                Total = 1,
                Manual = true,
                Mode = InteractionMode.Items
            },
            new CDisplayDuration
            {
                Process = GDOReferences.SearchBush.ID
            }
        };

        public override bool IsNonInteractive => false;

        public override void OnRegister(Appliance gameDataObject)
        {
            base.OnRegister(gameDataObject);
            HoldPointContainer holdPointContainer = gameDataObject.Prefab.AddComponent<HoldPointContainer>();
            holdPointContainer.HoldPoint = gameDataObject.Prefab.GetChild("HoldPoint").transform;
        }
    }
}