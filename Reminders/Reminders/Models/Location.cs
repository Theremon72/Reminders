namespace Reminders.Reminders.Models
{
    public class Location
    {
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Location(string name)
        {
            Name = name;
        }
    }
}