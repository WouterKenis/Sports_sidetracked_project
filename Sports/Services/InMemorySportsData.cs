using Sports.Models;
using System.Collections.Generic;

namespace Sports.Services
{
    public class InMemorySportsData : ISportsData
    {
        List<FootballPlayer> _footballPlayers;
        List<BasketballPlayer> _basketballPlayers;

        public InMemorySportsData()
        {
            _footballPlayers = new List<FootballPlayer>
            {
                new FootballPlayer
                {
                    Id = 1, Number = 11, Name = "Karim Benzema", TeamId = 1, YearlySalary = 8000000, Position = "Striker"
                },
                new FootballPlayer
                {
                    Id = 2, Number = 1, Name = "Thibaut Courtois", TeamId = 1, YearlySalary = 10000000, Position = "Keeper"
                },
                new FootballPlayer
                {
                    Id = 3, Number = 11, Name = "Lionel Messi", TeamId = 2, YearlySalary = 8000000, Position = "Striker"
                }
            };

            _basketballPlayers = new List<BasketballPlayer>
            {
                   new BasketballPlayer
                   {
                       Id = 1, Number = 99, Name = "Lebron James", TeamId = 1, YearlySalary = 50000000, Position = "Power Forward"
                   }
            };


        }

        public IEnumerable<BasketballPlayer> GetAllBasketballPlayers()
        {
            return _basketballPlayers;
        }

        public IEnumerable<FootballPlayer> GetAllFootballPlayers()
        {
            return _footballPlayers;
        }
    }
}