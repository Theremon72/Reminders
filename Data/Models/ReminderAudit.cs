using Reminders.Data.Models.enums;

namespace Reminders.Data.Models;

public class ReminderAudit : Entity
{
    public long Id { get; set; }
    public long ReminderId { get; set; }
    public long TriggerId { get; set; }

    /// <summary>
    /// The <see cref="enums.ActionTaken"/> by the user to create the audit
    /// </summary>
    public ActionTaken ActionTaken { get; set; }
    public DateTimeOffset DateTime { get; set; }

    /// <summary>
    /// the <see cref="enums.TriggerType"/> that prompted the action
    /// </summary>
    public TriggerType TriggerType { get; set; }

    public required Reminder Reminder { get; set; }
}
