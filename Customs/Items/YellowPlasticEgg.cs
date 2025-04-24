using System.Collections.Generic;
using Easter2025.Components;
using Easter2025.Customs.Generics;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class YellowPlasticEgg : GenericStackableItem
    {
        public override string UniqueNameID => "YellowPlasticEgg";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("YellowPlasticEgg").AssignMaterialsByNames();
        public override string ColourBlindTag => "Y";
        public override ItemValue ItemValue => ItemValue.SideSmall;
        public override List<IItemProperty> Properties => new List<IItemProperty>
        {
            new CHidableItem(),
            new CEggBasket.CanPlaceInBasket()
        };
    }
}