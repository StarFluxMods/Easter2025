using System.Collections.Generic;
using Easter2025.Views;
using HarmonyLib;
using Kitchen;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Patches
{
    [HarmonyPatch(typeof(LocalViewRouter), "GetPrefab")]
    public class LocalViewRouter_Patch3
    {
        public static GameObject result;
        public static GameObject container;
		
        static bool Prefix(LocalViewRouter __instance, ViewType view_type, ref GameObject __result)
        {
            if (view_type != Mod.BLUE_BUNNY_VIEW) return true;
            
            if (container == null)
            {
                container = new GameObject("temp");
                container.SetActive(false);
            }

            if (result == null)
            {
                result = GameObject.Instantiate(Mod.Bundle.LoadAsset<GameObject>("BlueBunny").AssignMaterialsByNames(), container.transform);
                BunnyEasterEggView bunnyEasterEggView = result.AddComponent<BunnyEasterEggView>();
                bunnyEasterEggView.GenericAnimator = result.GetChild("Container/Bunny").GetComponent<Animator>();
            }

            __result = result;
            return false;
        }
    }
}