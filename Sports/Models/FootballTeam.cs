using System.Collections.Generic;

namespace Sports.Models
{
    public class FootballTeam
    {

        public FootballTeam()
        {
            Players = new List<FootballPlayer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Stadium { get; set; }
        public List<FootballPlayer> Players { get; set; }
    }
}
