using System.Collections.Generic;
using Easter2025.Components;
using Easter2025.Customs.Generics;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class PinkPlasticEgg : GenericStackableItem
    {
        public override string UniqueNameID => "PinkPlasticEgg";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PinkPlasticEgg").AssignMaterialsByNames();
        public override string ColourBlindTag => "P";
        public override List<IItemProperty> Properties => new List<IItemProperty>
        {
            new CHidableItem()
        };
    }
}