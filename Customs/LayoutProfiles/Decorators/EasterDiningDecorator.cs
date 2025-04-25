using System.Collections.Generic;
using System.Linq;
using Easter2025.Utilies;
using Kitchen;
using Kitchen.Layouts;
using KitchenLib.References;
using UnityEngine;

namespace Easter2025.Customs.LayoutProfiles.Decorators
{
    public class EasterDiningDecorator : Decorator
    {
        private List<LayoutPosition> used_positions = new List<LayoutPosition>();
        public override bool Decorate(Room room)
        {
            List<CLayoutAppliancePlacement> bushesToAdd = new List<CLayoutAppliancePlacement>();
            List<CLayoutAppliancePlacement> tablesToAdd = new List<CLayoutAppliancePlacement>();
            int minBushes = 3;
            int maxBushes = 5;
            List<LayoutPosition> ShuffledPositions = (from r in Blueprint.TilesOfRoom(room) orderby UnityEngine.Random.value select r).ToList();
            
            for (int i = 0; i < 8; i++)
            {
                if (FindValidPlacementLocation(ShuffledPositions, out LayoutPosition result, 10))
                {
                    if (Random.value < 0.5f)
                    {
                        if (bushesToAdd.Count < maxBushes)
                        {
                            bushesToAdd.Add(new CLayoutAppliancePlacement
                            {
                                Position = result,
                                Appliance = GDOReferences.Bush.ID,
                                Rotation = new Quaternion(0, Random.Range(0, 360), 0, 0)
                            });
                            used_positions.Add(result);
                            foreach (LayoutPosition position in LayoutHelpers.AllNearby)
                            {
                                used_positions.Add(result + position);
                            }
                        }
                    }
                    else
                    {
                        if (tablesToAdd.Count < Profile.MaximumTables)
                        {
                            tablesToAdd.Add(new CLayoutAppliancePlacement
                            {
                                Position = result,
                                Appliance = Profile.Table.ID,
                                Rotation = Quaternion.identity
                            });
                            used_positions.Add(result);
                            foreach (LayoutPosition position in LayoutHelpers.AllNearby)
                            {
                                used_positions.Add(result + position);
                            }
                        }
                    }
                }
            }

            if (bushesToAdd.Count > maxBushes || bushesToAdd.Count <= minBushes || tablesToAdd.Count > Profile.MaximumTables) return false;
            
            foreach (var decoration in bushesToAdd)
            {
                Decorations.Add(decoration);
            }
            foreach (var decoration in tablesToAdd)
            {
                Decorations.Add(decoration);
            }

            return true;

        }

        private bool FindValidPlacementLocation(List<LayoutPosition> positions, out LayoutPosition result, int attempts = 5)
        {
            result = default;
            if (attempts < 0) return false;
            LayoutPosition randomPosition = positions[Random.Range(0, positions.Count)];
            if (!used_positions.Contains(randomPosition) && !Blueprint.HasFeature(randomPosition) && Blueprint.IsTileOpenSpace(randomPosition))
            {
                result = randomPosition;
                return true;
            }
            
            return FindValidPlacementLocation(positions, out result, attempts - 1);
        }
    }
}