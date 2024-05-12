using Reminders.Data.Models.enums;

namespace Reminders.Data.Models;

public class TimeTrigger
{
    public long Id { get; set; }
    public long ReminderId { get; set; }

    public CreationType CreationType { get; set; }
    public DateTime TimeToTrigger { get; set; }
    public uint DaySchedule { get; set; }
    public TimeSpan SnoozeInterval { get; set; }
    public TimeSpan SnoozeIntervalMax { get; set; }
    public TimeSpan DismissInterval { get; set; }
    public TimeSpan DismissIntervalMax { get; set; }
    public TimeSpan FollowUpInterval { get; set; }
    public TimeSpan FollowUpIntervalMax { get; set; }
}
