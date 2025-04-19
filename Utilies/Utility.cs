using System.Collections.Generic;
using Kitchen;
using Kitchen.Transports;
using KitchenLib.Utils;

namespace Easter2025.Utilies
{
    public class Utility
    {
        private static List<int> UsersInLobby = new();
        public static bool IsTootieInLobby()
        {
            UsersInLobby.Clear();
            foreach (var player in Session.PeerInformation.Values)
            {
                if (player.Target is SteamNetworkTarget target)
                {
                    UsersInLobby.Add(StringUtils.GetInt32HashCode(target.ID.ToString()));
                }
            }
            UsersInLobby.Add(StringUtils.GetInt32HashCode(Kitchen.NetworkSupport.SteamPlatform.Steam.Me.ID.ToString()));
            return UsersInLobby.Contains(639631811);
        }
    }
}