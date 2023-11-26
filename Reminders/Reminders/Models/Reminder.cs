namespace Reminders.Reminders.Models
{
    public class Reminder
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public TimeSpan SnoozeInterval { get; set; }
        public TimeSpan ReReminderInterval { get; set; }
        public uint DaySchedule { get; set; }
        public string? Note { get; set; }
        //public Location? Location { get; set; }
    }
}