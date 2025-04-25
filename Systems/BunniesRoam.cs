using System.Collections.Generic;
using Easter2025.Components;
using Kitchen;
using Kitchen.Layouts;
using KitchenData;
using KitchenMods;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;
using UnityEngine.AI;

namespace Easter2025.Systems
{
    public class BunniesRoam : GameSystemBase, IModSystem
    {
        private EntityQuery _Bunnies;
        private NavMeshPath Path = new NavMeshPath();
        protected override void Initialise()
        {
            base.Initialise();
            _Bunnies = GetEntityQuery(typeof(CBunny));
        }

        private float range = 5f;
        
        protected override void OnUpdate()
        {
            List<Vector3> list = GetPostTiles(true);
            using (NativeArray<Entity> Bunnies = _Bunnies.ToEntityArray(Allocator.Temp))
            {
                foreach (Entity Bunny in Bunnies)
                {
                    if (Require(Bunny, out CPosition cPosition))
                    {
                        if (!Has<CMoveToLocation>(Bunny))
                        {
                            int num = 0;
                            Set(Bunny, new CMoveToLocation
                            {
                                Location  = FindMovementLocation(cPosition),
                                StoppingDistance = 0.8f
                            });
                        }

                        if (Require(Bunny, out CMoveToLocation cMoveToLocation))
                        {
                            if (Random.value <= 0.1f * Time.DeltaTime || Input.GetKeyDown(KeyCode.L))
                            {
                                if (Vector3.Distance(cMoveToLocation.Location, cPosition) < 1f)
                                {
                                    cMoveToLocation.Location = FindMovementLocation(cPosition);

                                    Set(Bunny, cMoveToLocation);
                                }
                            }
                        }
                    }
                }
            }
        }

        private Vector3 FindMovementLocation(Vector3 startingPosition)
        {
            for (var i = 0; i < 50; i++)
            {
                Vector3 pos = startingPosition + new Vector3(Random.Range(-range, range), 0, Random.Range(-range, range));
                if (TileManager.GetOccupant(pos) != default)
                {
                    if (TileManager.GetTile(startingPosition).RoomID == TileManager.GetTile(pos).RoomID)
                    {
                        NavMesh.CalculatePath(startingPosition, pos, NavMesh.AllAreas, Path);
                        if (Path.status == NavMeshPathStatus.PathComplete)
                        {
                            return pos;
                        }
                    }
                }
            }
            return startingPosition;
        }
    }
}