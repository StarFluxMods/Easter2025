using System.Collections.Generic;
using Easter2025.Customs.Generics;
using Easter2025.Utilies;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class EasterBread : GenericStackableItem
    {
        public override string UniqueNameID => "EasterBread";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("EasterBread").AssignMaterialsByNames();
        public override ItemValue ItemValue => ItemValue.Small;
        public override string ColourBlindTag => "E";

        public override List<Item> SatisfiedBy => new List<Item>
        {
            GDOReferences.EasterBread,
            GDOReferences.RedEasterBread,
            GDOReferences.GreenEasterBread,
            GDOReferences.BlueEasterBread,
        };
    }
}