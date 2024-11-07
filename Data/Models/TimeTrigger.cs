using Reminders.Data.Models.enums;

namespace Reminders.Data.Models;

/// <summary>
/// This represents a <see cref="Reminder"/>s trigger for when it should alarm the user.
/// </summary>
public class TimeTrigger : Entity
{
    public long Id { get; set; }
    public long ReminderId { get; set; }

    /// <summary>
    /// Indicates this time trigger should be removed once completed
    /// </summary>
    public bool IsTemporary { get; set; }

    /// <summary>
    /// How this trigger was created
    /// </summary>
    public CreationType CreationType { get; set; }

    /// <summary>
    /// The UTC time to trigger the initial alarm
    /// </summary>
    public DateTimeOffset TimeToTrigger { get; set; }

    /// <summary>
    /// Collection of Days to fire the trigger 
    /// </summary>
    public IList<DayOfWeek>? DaySchedule { get; set; }

    /// <summary>
    /// Time interval in seconds when snoozing
    /// </summary>
    public TimeSpan SnoozeInterval { get; set; }

    /// <summary>
    /// The maximum amount of time the interval can be snoozed for before disabling snooze
    /// </summary>
    public TimeSpan SnoozeIntervalMax { get; set; }

    /// <summary>
    /// Time interval in seconds when dismissing
    /// </summary>
    public TimeSpan DismissInterval { get; set; }

    /// <summary>
    /// The maximum amount of time before disabling dismiss
    /// </summary>
    public TimeSpan DismissIntervalMax { get; set; }

    /// <summary>
    /// The time interval in which to trigger a follow up to ensure completion
    /// </summary>
    public TimeSpan FollowUpInterval { get; set; }

    /// <summary>
    /// The maximum time a follow up can be requested
    /// </summary>
    public TimeSpan FollowUpIntervalMax { get; set; }
}
