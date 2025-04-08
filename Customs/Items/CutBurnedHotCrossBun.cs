using Easter2025.Customs.Generics;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class CutBurnedHotCrossBun : GenericStackableItem
    {
        public override string UniqueNameID => "CutBurnedHotCrossBun";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CutBurnedHotCrossBun").AssignMaterialsByNames();
    }
}