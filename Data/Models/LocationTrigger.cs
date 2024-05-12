namespace Reminders.Data.Models;

public class LocationTrigger
{
    public long Id { get; set; }
    public long ReminderId { get; set; }

    public float Latitude { get; set; }
    public float Longitude { get; set; }
    public int Range { get; set; }
    public TimeSpan Delay { get; set; }
}
