namespace RemindersHtmx.Data;

public class Reminder
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateTime { get; set; }
    public TimeSpan SnoozeInterval { get; set; }
    public TimeSpan ReReminderInterval { get; set; }
    public uint DaySchedule { get; set; }
    public string? Note { get; set; }
    //public Location? Location { get; set; }
}