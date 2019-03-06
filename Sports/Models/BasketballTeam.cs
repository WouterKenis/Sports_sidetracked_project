using System.Collections.Generic;

namespace Sports.Models
{
    public class BasketballTeam
    {
        public BasketballTeam()
        {
            Players = new List<BasketballPlayer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Stadium { get; set; }
        public List<BasketballPlayer> Players { get; set; }
    }
}
