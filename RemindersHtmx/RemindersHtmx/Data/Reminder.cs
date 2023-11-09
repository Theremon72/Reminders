using System.ComponentModel.DataAnnotations;

namespace RemindersHtmx.Data;

public class Reminder
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateTime { get; set; }
    [Display(Name = "Snooze")]
    public TimeSpan SnoozeInterval { get; set; }
    [Display(Name = "ReReminder")]
    public TimeSpan ReReminderInterval { get; set; }
    [Display(Name = "Days")]
    public uint DaySchedule { get; set; }
    public string? Note { get; set; }
    //public Location? Location { get; set; }
}