using Easter2025.Components;
using Easter2025.Systems;
using HarmonyLib;
using Kitchen;
using Unity.Entities;

namespace Easter2025.Patches
{
    [HarmonyPatch(typeof(AcceptIntoBin), "AcceptTransfer")]
    public class AcceptIntoBinPatch
    {
        static void Prefix(Entity proposal_entity)
        {
            if (UtilitySystem._Require(proposal_entity, out CItemTransferProposal cItemTransferProposal))
            {
                if (UtilitySystem._Has<CCanTriggerOrbs>(cItemTransferProposal.Item))
                {
                    if (!UtilitySystem._Has<CHasOrbs>(cItemTransferProposal.Destination))
                    {
                        UtilitySystem._Set(cItemTransferProposal.Destination, new CHasOrbs());
                    }
                }
            }
        }
    }
}