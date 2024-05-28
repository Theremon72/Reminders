namespace Reminders.Data.Models.enums;

public enum TriggerType
{
    /// <summary>
    /// Created by the system
    /// </summary>
    System,
    /// <summary>
    /// Created by user
    /// </summary>
    UserCreated,
    /// <summary>
    /// Created by user interacting with snooze
    /// </summary>
    Snooze,
    /// <summary>
    /// Created by user interacting with dismiss
    /// </summary>
    Dismiss,
    /// <summary>
    /// Created by user interacting with followup
    /// </summary>
    FollowUp,
    /// <summary>
    /// Created by Location being reached
    /// </summary>
    Location
}
