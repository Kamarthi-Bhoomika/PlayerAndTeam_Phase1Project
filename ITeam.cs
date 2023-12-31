﻿using System.Collections.Generic;

namespace PlayerAndTeam_Phase1Project
{
    interface ITeam
    {
        void Add(Player player);
        void Remove(int playerid);
        void GetPlayerById(int playerId);
        void GetPlayerByName(string playerName);
        List<Player> GetAllPlayers();
    }
}
