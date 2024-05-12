namespace Reminders.Data.Models;

public class Reminder
{
    public long Id { get; set; }
    public bool IsDeleted { get; set; }

    public bool Important { get; set; }
    public string? Note { get; set; }
    public string? Title { get; set; }

    public ICollection<TimeTrigger>? TimeTriggers { get; set; }
    public ICollection<LocationTrigger>? LocationTriggers { get; set; }
}
