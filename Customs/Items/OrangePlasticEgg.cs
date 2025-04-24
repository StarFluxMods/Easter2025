using System.Collections.Generic;
using Easter2025.Components;
using Easter2025.Customs.Generics;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Items
{
    public class OrangePlasticEgg : GenericStackableItem
    {
        public override string UniqueNameID => "OrangePlasticEgg";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("OrangePlasticEgg").AssignMaterialsByNames();
        public override string ColourBlindTag => "O";
        public override ItemValue ItemValue => ItemValue.SideSmall;
        public override List<IItemProperty> Properties => new List<IItemProperty>
        {
            new CHidableItem(),
            new CEggBasket.CanPlaceInBasket()
        };
    }
}