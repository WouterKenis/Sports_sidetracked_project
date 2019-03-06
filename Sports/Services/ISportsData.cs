using Sports.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports.Services
{
    public interface ISportsData
    {

        IEnumerable<FootballPlayer> GetAllFootballPlayers();
        IEnumerable<BasketballPlayer> GetAllBasketballPlayers();

    }
}
