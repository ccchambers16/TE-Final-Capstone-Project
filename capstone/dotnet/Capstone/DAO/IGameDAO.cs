﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone.Models; 

namespace Capstone.DAO
{
    public interface IGameDAO
    {
        Game CreateGameId(Game game);

        Game CreateGameById(int newGameId, int userId);

        List<Holdings> ViewGamesByUserId(int id);

        Game InvitePlayer(int userId, Game game);

        //Game GetGamesById(int id);
    }
}