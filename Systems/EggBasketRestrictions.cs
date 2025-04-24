using Kitchen;
using KitchenMods;
using Easter2025.Components;
using KitchenLib.References;
using Unity.Collections;
using Unity.Entities;

namespace Easter2025.Systems
{
    [UpdateInGroup(typeof(ItemTransferEarlyPrune))]
    public class EggBasketRestrictions : GameSystemBase, IModSystem
    {
        private EntityQuery _TransferProposals;

        protected override void Initialise()
        {
            _TransferProposals = GetEntityQuery(typeof(CItemTransferProposal));
        }

        protected override void OnUpdate()
        {
            NativeArray<Entity> entities = _TransferProposals.ToEntityArray(Allocator.Temp);
            NativeArray<CItemTransferProposal> components = _TransferProposals.ToComponentDataArray<CItemTransferProposal>(Allocator.Temp);

            using (NativeArray<Entity> TransferProposals = _TransferProposals.ToEntityArray(Allocator.Temp))
            {
                foreach (Entity TransferProposal in TransferProposals)
                {
                    if (!Require(TransferProposal, out CItemTransferProposal cItemTransferProposal)) continue;
                    if (cItemTransferProposal.Status == ItemTransferStatus.Pruned) continue;
                    if ((!Require(cItemTransferProposal.Destination, out CToolUser cToolUser) || !Has<CEggBasket>(cToolUser.CurrentTool)) && (!Require(cItemTransferProposal.Destination, out CItemHolder cItemHolder) || !Has<CEggBasket>(cItemHolder.HeldItem))) continue;
                    if (Has<CEggBasket.CanPlaceInBasket>(cItemTransferProposal.Item)) continue;
                    cItemTransferProposal.Status = ItemTransferStatus.Pruned;
                    SetComponent(TransferProposal, cItemTransferProposal);

                }
            }
        }
    }
}