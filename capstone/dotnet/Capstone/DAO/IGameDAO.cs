﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone.Models; 

namespace Capstone.DAO
{
    public interface IGameDAO
    {
        int CreateGameId(int userId, string gameName);

        int CreateGameById(int newGameId, int userId);

        List<Holdings> ViewGamesByUserId(int id);

        int InvitePlayer(int userId, Game gameId);

    }
}
