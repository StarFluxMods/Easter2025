using System.IO;
using System.Linq;
using System.Reflection;
using Easter2025.Customs.RestaurantSettings;
using Easter2025.Utilies;
using Easter2025.Views;
using Kitchen;
using KitchenData;
using KitchenLib;
using KitchenLib.Event;
using KitchenLib.Interfaces;
using KitchenLib.Logging.Exceptions;
using KitchenLib.References;
using KitchenLib.Utils;
using KitchenMods;
using UnityEngine;
using KitchenLogger = KitchenLib.Logging.KitchenLogger;

namespace Easter2025
{
    public class Mod : BaseMod, IModSystem, IAutoRegisterAll
    {
        public const string MOD_GUID = "com.starfluxgames.easter2025";
        public const string MOD_NAME = "Easter 2025";
        public const string MOD_VERSION = "0.0.4";
        public const string MOD_AUTHOR = "StarFluxGames";
        public const string MOD_GAMEVERSION = ">=1.2.1";

        internal static AssetBundle Bundle;
        internal static KitchenLogger Logger;

        internal static ViewType RED_BUNNY_VIEW = (ViewType)VariousUtils.GetID("RED_BUNNY_VIEW");
        internal static ViewType GREEN_BUNNY_VIEW = (ViewType)VariousUtils.GetID("GREEN_BUNNY_VIEW");
        internal static ViewType BLUE_BUNNY_VIEW = (ViewType)VariousUtils.GetID("BLUE_BUNNY_VIEW");

        public static bool ENABLE_ADDITIONAL_LOBBY_DISHES = false;

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

            //achievementsManager = new AchievementsManager(MOD_GUID, MOD_NAME);
            //achievementsManager.RegisterAchievement(new Achievement("1", "Salmon Sensations1", "Serve a Salmon Roll to a customer.", new Texture2D(1, 1)).SetHiddenState(AchievementHiddenState.NotHidden));
            //achievementsManager.RegisterAchievement(new Achievement("2", "Salmon Sensations2", "Serve a Salmon Roll to a customer.", new Texture2D(1, 1)).SetHiddenState(AchievementHiddenState.HiddenUntilUnlocked));
            //achievementsManager.RegisterAchievement(new Achievement("3", "Salmon Sensations3", "Serve a Salmon Roll to a customer.", new Texture2D(1, 1)).SetHiddenState(AchievementHiddenState.HiddenUntilCompleted));

            //achievementsManager.Load();
            //achievementsManager.Save();

            // RefGenerator.GenerateGDOReferences(Assembly.GetExecutingAssembly(), Path.Combine(Application.persistentDataPath, "GeneratedReferences.cs"));
            
            Events.BuildGameDataEvent += (sender, args) =>
            {
                if (args.firstBuild)
                {
                    // Adding Orbs to Bin
                    if (args.gamedata.TryGet(PlayerCosmeticReferences.BunnyEarHat, out PlayerCosmetic BunnyEarHat))
                    {
                        BunnyEarHat.CustomerSettings.Add((RestaurantSetting)GDOUtils.GetCustomGameDataObject<Easter2025GardenSetting>().GameDataObject);
                        BunnyEarHat.CustomerSettings.Add((RestaurantSetting)GDOUtils.GetCustomGameDataObject<Easter2025Setting>().GameDataObject);
                    }
                    // Adding Orbs to Bin
                    if (args.gamedata.TryGet(ApplianceReferences.Bin, out Appliance Bin))
                    {
                        GameObject Orbs = GameObject.Instantiate(Bundle.LoadAsset<GameObject>("Orb Container"));
                        Orbs.transform.SetParent(Bin.Prefab.transform);
                        Orbs.transform.localPosition = Vector3.zero;
                        Orbs.SetActive(false);

                        BinOrbView view = Bin.Prefab.AddComponent<BinOrbView>();
                        view.OrbContainer = Orbs;
                    }

                    if (args.gamedata.TryGet(ApplianceReferences.Countertop, out Appliance Countertop))
                    {
                        // Adding Processes to Egg Mould Provider
                        if (args.gamedata.TryGet(GDOReferences.EggMouldProvider.ID, out Appliance EggMouldProvider))
                        {
                            foreach (Appliance.ApplianceProcesses process in Countertop.Processes)
                            {
                                bool found = false;
                                foreach (Appliance.ApplianceProcesses process2 in EggMouldProvider.Processes)
                                {
                                    if (process.Process == process2.Process)
                                    {
                                        found = true;
                                        break;
                                    }
                                }

                                if (!found)
                                {
                                    EggMouldProvider.Processes.Add(process);
                                }
                            }
                        }
                        
                        // Adding Processes to Wrapper Provider
                        if (args.gamedata.TryGet(GDOReferences.WrapperProvider.ID, out Appliance WrapperProvider))
                        {
                            foreach (Appliance.ApplianceProcesses process in Countertop.Processes)
                            {
                                bool found = false;
                                foreach (Appliance.ApplianceProcesses process2 in WrapperProvider.Processes)
                                {
                                    if (process.Process == process2.Process)
                                    {
                                        found = true;
                                        break;
                                    }
                                }

                                if (!found)
                                {
                                    WrapperProvider.Processes.Add(process);
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}