using System.IO;
using System.Linq;
using System.Reflection;
using Easter2025.Components;
using Easter2025.Customs.RestaurantSettings;
using Easter2025.Utilies;
using Easter2025.Views;
using Kitchen;
using KitchenData;
using KitchenLib;
using KitchenLib.Achievements;
using KitchenLib.Event;
using KitchenLib.Interfaces;
using KitchenLib.Logging.Exceptions;
using KitchenLib.References;
using KitchenLib.Utils;
using KitchenMods;
using TMPro;
using UnityEngine;
using KitchenLogger = KitchenLib.Logging.KitchenLogger;

namespace Easter2025
{
    public class Mod : BaseMod, IModSystem, IAutoRegisterAll
    {
        public const string MOD_GUID = "com.starfluxgames.easter2025";
        public const string MOD_NAME = "The Great Eggscape";
        public const string MOD_VERSION = "0.1.1";
        public const string MOD_AUTHOR = "StarFluxGames";
        public const string MOD_GAMEVERSION = ">=1.2.1";

        internal static AssetBundle Bundle;
        internal static KitchenLogger Logger;
        internal static AchievementsManager achievementsManager;

        internal static readonly ViewType RED_BUNNY_VIEW = (ViewType)VariousUtils.GetID("RED_BUNNY_VIEW");
        internal static readonly ViewType GREEN_BUNNY_VIEW = (ViewType)VariousUtils.GetID("GREEN_BUNNY_VIEW");
        internal static readonly ViewType BLUE_BUNNY_VIEW = (ViewType)VariousUtils.GetID("BLUE_BUNNY_VIEW");
        internal static readonly ViewType ROAMING_RED_BUNNY_VIEW = (ViewType)VariousUtils.GetID("ROAMING_RED_BUNNY_VIEW");
        internal static readonly ViewType ROAMING_GREEN_BUNNY_VIEW = (ViewType)VariousUtils.GetID("ROAMING_GREEN_BUNNY_VIEW");
        internal static readonly ViewType ROAMING_BLUE_BUNNY_VIEW = (ViewType)VariousUtils.GetID("ROAMING_BLUE_BUNNY_VIEW");

        internal static readonly string ACHIEVEMENT_SERVE_THREE_COURSE_EGGS = "ACHIEVEMENT_SERVE_THREE_COURSE_EGGS";
        internal static readonly string ACHIEVEMENT_TRIGGER_BUNNIES = "ACHIEVEMENT_TRIGGER_BUNNIES";

        public static readonly bool ENABLE_ADDITIONAL_LOBBY_DISHES = false;

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

            achievementsManager = new AchievementsManager(MOD_GUID, MOD_NAME);
            achievementsManager.RegisterAchievement(new Achievement(ACHIEVEMENT_SERVE_THREE_COURSE_EGGS, "An Eggcellent Meal", "Serve 3 different egg courses to a single customer", Bundle.LoadAsset<Texture2D>("EggBasketIcon")).SetHiddenState(AchievementHiddenState.NotHidden));
            achievementsManager.RegisterAchievement(new Achievement(ACHIEVEMENT_TRIGGER_BUNNIES, "Bunnies?", "Complete the hidden Easter Egg for some fancy bunnies!", Bundle.LoadAsset<Texture2D>("BunnyIcon")).SetHiddenState(AchievementHiddenState.HiddenUntilCompleted));

            achievementsManager.Load();
            achievementsManager.Save();
            
            var spriteAsset = Bundle.LoadAsset<TMP_SpriteAsset>("SearchingIcon");
            TMP_Settings.defaultSpriteAsset.fallbackSpriteAssets.Add(spriteAsset);
            spriteAsset.material = Object.Instantiate(TMP_Settings.defaultSpriteAsset.material);
            spriteAsset.material.mainTexture = Bundle.LoadAsset<Texture2D>("SearchingIcon_Tex");

            // RefGenerator.GenerateGDOReferences(Assembly.GetExecutingAssembly(), Path.Combine(Application.persistentDataPath, "GeneratedReferences.cs"));
            
            Events.BuildGameDataEvent += (sender, args) =>
            {
                if (args.firstBuild)
                {
                    // Adding Carrot Checker
                    if (args.gamedata.TryGet(ItemReferences.Carrot, out Item carrot) && args.gamedata.TryGet(ItemReferences.CarrotChopped, out Item carrotChopped))
                    {
                        carrot.Properties.Add(new CCanTriggerOrangeOrbs());
                        carrotChopped.Properties.Add(new CCanTriggerOrangeOrbs());
                    }

                    // Adding Bunny Ears
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
                        Orbs.SetActive(true);

                        BinOrbView view = Bin.Prefab.AddComponent<BinOrbView>();
                        view.GreenOrbs = Orbs.GetChild("GreenOrbs");
                        view.OrangeOrbs = Orbs.GetChild("OrangeOrbs");
                        view.GreenOrbs.SetActive(false);
                        view.OrangeOrbs.SetActive(false);
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
                        
                        // Adding Processes to EggBasket Provider
                        if (args.gamedata.TryGet(GDOReferences.EggBasketProvider.ID, out Appliance EggBasketProvider))
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
                                    EggBasketProvider.Processes.Add(process);
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}