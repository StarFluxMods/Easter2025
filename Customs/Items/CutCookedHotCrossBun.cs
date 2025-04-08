using Easter2025.Customs.Generics;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class CutCookedHotCrossBun : GenericStackableItem
    {
        public override string UniqueNameID => "CutCookedHotCrossBun";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CutCookedHotCrossBun").AssignMaterialsByNames();
    }
}