using System.Collections.Generic;
using System.Linq;
using Easter2025.Utilies;
using Kitchen;
using KitchenData;
using KitchenMods;
using Unity.Collections;
using Unity.Entities;


namespace Easter2025.Systems
{
    public class DishLockedDecor : StartOfDaySystem, IModSystem
    {
        private EntityQuery _CurrentMenuItems;

        protected override void Initialise()
        {
            base.Initialise();
            _CurrentMenuItems = base.GetEntityQuery(typeof(CMenuItem), typeof(CAvailableIngredient));
        }

        private static Dictionary<int, List<Decor>> Decor = new Dictionary<int, List<Decor>>
        {
            {
                GDOReferences.DishDyedEggs.ID, new List<Decor>
                {
                    GDOReferences.EggWallpaper
                }
            }
        };

        protected override void OnUpdate()
        {
            foreach (Decor decor in Decor.Keys.SelectMany(id => Decor[id]))
            {
                decor.IsAvailable = false;
            }

            using (NativeArray<Entity> CurrentMenuItems = _CurrentMenuItems.ToEntityArray(Allocator.Temp))
            {
                foreach (Entity CurrentMenuItem in CurrentMenuItems)
                {
                    if (!Require(CurrentMenuItem, out CMenuItem cMenuItem)) continue;
                    if (!Decor.ContainsKey(cMenuItem.SourceDish)) continue;
                    foreach (Decor decor in Decor[cMenuItem.SourceDish])
                    {
                        decor.IsAvailable = true;
                    }
                }
            }
        }
    }
}