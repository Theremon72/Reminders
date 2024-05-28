namespace Reminders.Data.Models;

/// <summary>
/// This represents the information to remind the user of and the associated triggers.
/// </summary>
public class Reminder : Entity
{
    public long Id { get; set; }

    /// <summary>
    /// Tag to display/insist that this reminder should not be snoozed or delayed
    /// </summary>
    public bool Important { get; set; }

    /// <summary>
    /// Any extra notes beyond the title to display
    /// </summary>
    public string? Note { get; set; }
    public string? Title { get; set; }

    /// <summary>
    /// A collection of <see cref="TimeTrigger"/>s
    /// </summary>
    public ICollection<TimeTrigger>? TimeTriggers { get; set; }

    /// <summary>
    /// A collection of <see cref="LocationTrigger"/>
    /// </summary>
    public ICollection<LocationTrigger>? LocationTriggers { get; set; }
}
