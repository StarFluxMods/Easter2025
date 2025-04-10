using System.Linq;
using System.Reflection;
using Easter2025.Views;
using HarmonyLib;
using KitchenData;
using KitchenLib;
using KitchenLib.Event;
using KitchenLib.Interfaces;
using KitchenLib.Logging.Exceptions;
using KitchenLib.References;
using KitchenMods;
using UnityEngine;
using KitchenLogger = KitchenLib.Logging.KitchenLogger;

namespace Easter2025
{
    public class Mod : BaseMod, IModSystem, IAutoRegisterAll
    {
        public const string MOD_GUID = "com.starfluxgames.easter2025";
        public const string MOD_NAME = "Easter 2025";
        public const string MOD_VERSION = "0.1.0";
        public const string MOD_AUTHOR = "StarFluxGames";
        public const string MOD_GAMEVERSION = ">=1.2.1";

        internal static AssetBundle Bundle;
        internal static KitchenLogger Logger;

        public Mod() : base(MOD_GUID, MOD_NAME, MOD_AUTHOR, MOD_VERSION, MOD_GAMEVERSION, Assembly.GetExecutingAssembly())
        {
        }

        protected override void OnInitialise()
        {
            Logger.LogWarning($"{MOD_GUID} v{MOD_VERSION} in use!");
        }

        protected override void OnUpdate()
        {
        }

        protected override void OnPostActivate(KitchenMods.Mod mod)
        {
            Bundle = mod.GetPacks<AssetBundleModPack>().SelectMany(e => e.AssetBundles).FirstOrDefault() ?? throw new MissingAssetBundleException(MOD_GUID);
            Logger = InitLogger();

            // RefGenerator.GenerateGDOReferences(Assembly.GetExecutingAssembly(), Path.Combine(Application.persistentDataPath, "GeneratedReferences.cs"));

            Events.BuildGameDataEvent += (sender, args) =>
            {
                if (args.firstBuild && args.gamedata.TryGet(ApplianceReferences.Bin, out Appliance Bin))
                {
                    GameObject Orbs = GameObject.Instantiate(Bundle.LoadAsset<GameObject>("Orb Container"));
                    Orbs.transform.SetParent(Bin.Prefab.transform);
                    Orbs.transform.localPosition = Vector3.zero;
                    Orbs.SetActive(false);

                    BinOrbView view = Bin.Prefab.AddComponent<BinOrbView>();
                    view.OrbContainer = Orbs;
                }
            };
        }
    }
}