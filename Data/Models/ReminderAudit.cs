using Reminders.Data.Models.enums;

namespace Reminders.Data.Models;

public class ReminderAudit
{
    public long Id { get; set; }
    public long ReminderId { get; set; }

    public ActionTaken ActionTaken { get; set; }
    public DateTime DateTime { get; set; }
    public TriggerType TriggerType { get; set; }

    public required Reminder Reminder { get; set; }
}
