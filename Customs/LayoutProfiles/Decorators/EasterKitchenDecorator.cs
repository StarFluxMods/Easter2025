using System.Collections.Generic;
using System.IO;
using System.Linq;
using Kitchen;
using Kitchen.Layouts;
using KitchenData;
using UnityEngine;

namespace Easter2025.Customs.LayoutProfiles.Decorators
{
    public class EasterKitchenDecorator : Decorator
    {
        public override bool Decorate(Room room)
        {
            Queue<GameDataObject> queue = new Queue<GameDataObject>(Profile.RequiredAppliances);
            List<Vector3> used_tiles = new List<Vector3>(Decorations.Select((CLayoutAppliancePlacement d) => d.Position));
            HashSet<LayoutPosition> room_tiles = Blueprint.TilesOfRoom(room);
            foreach (LayoutPosition item in room_tiles)
            {
                if (Blueprint.HasFeature(item, FeatureType.Hatch))
                {
                    Decorations.Add(new CLayoutAppliancePlacement
                    {
                        Appliance = Profile.Counter.ID,
                        Position = item,
                        Rotation = FindWallRotation(item)
                    });
                    used_tiles.Add(item);
                }
            }

            int counter = 0;
            var internalWalls = GetInternalWalls(room).Where(x => !used_tiles.Contains(x)).ToList();
            
            LayoutPosition layoutPosition = next_tile(Kitchen.RandomExtensions.Random(GetInternalWalls(room).Where(x => !used_tiles.Contains(x)).ToList()));
            while (queue.Count > 0)
            {
                if (used_tiles.Contains(internalWalls[counter]) || Blueprint.HasFeature(internalWalls[counter], FeatureType.Door))
                {
                    counter++;
                    continue;
                }

                Decorations.Add(new CLayoutAppliancePlacement
                {
                    Appliance = queue.Dequeue().ID,
                    Position = internalWalls[counter],
                    Rotation = FindWallRotation(internalWalls[counter])
                });
                used_tiles.Add(internalWalls[counter]);
                counter++;
            }
            return true;
            LayoutPosition next_tile(LayoutPosition tile)
            {
                foreach (LayoutPosition item2 in Blueprint.AdjacentInRoom(tile).Concat(room_tiles))
                {
                    if (Blueprint.IsTileAccessible(item2) && !used_tiles.Contains(item2))
                    {
                        used_tiles.Add(item2);
                        return item2;
                    }
                }
                throw new LayoutFailureException("Not enough spaces to place kitchen equipment");
                
            }
        }

        private List<LayoutPosition> GetInternalWalls(Room room)
        {
            List<LayoutPosition> walls = new List<LayoutPosition>();
            var room_tiles = Blueprint.TilesOfRoom(room);
            foreach (var tile in room_tiles)
            {
                foreach (var walltile in Blueprint.GetWalls(tile))
                {
                    walls.Add(tile);
                }
            }

            return walls;
        }

        private Quaternion FindWallRotation(LayoutPosition pos)
        {
            Room room = Blueprint[pos];
            foreach (LayoutPosition layoutPosition in LayoutHelpers.Directions)
            {
                LayoutPosition layoutPosition2 = layoutPosition + pos;
                if (Blueprint[layoutPosition2].ID != room.ID)
                {
                    return Quaternion.LookRotation(new Vector3(layoutPosition.x, 0f, layoutPosition.y), Vector3.up);
                }
            }

            return Quaternion.identity;
        }
    }
}