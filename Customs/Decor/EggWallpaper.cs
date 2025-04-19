using Easter2025.Utilies;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Customs.Decor
{
    public class EggWallpaper : CustomDecor
    {
        public override string UniqueNameID => "EggWallpaper";
        public override Material Material => MaterialUtils.GetCustomMaterial("EggWallpaper");
        public override Appliance ApplicatorAppliance => GDOReferences.WallpaperApplicator;
        public override LayoutMaterialType Type => LayoutMaterialType.Wallpaper;
        public override bool IsAvailable => false;
    }
}