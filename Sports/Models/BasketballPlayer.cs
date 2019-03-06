namespace Sports.Models
{
    public class BasketballPlayer
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public BasketballTeam BasketballTeam { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal YearlySalary { get; set; }
    }
}
