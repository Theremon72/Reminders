namespace Reminders.Data.Models;

/// <summary>
/// This represents the information to remind the user of and the associated triggers.
/// </summary>
public class Reminder : Entity
{
    public long Id { get; init; }

    /// <summary>
    /// Tag to display/insist that this reminder should not be snoozed or delayed
    /// </summary>
    public bool Important { get; set; }

    /// <summary>
    /// Any extra notes beyond the title to display
    /// </summary>
    public string Note { get; set; } = String.Empty;
    public string Title { get; set; } = String.Empty;

    /// <summary>
    /// A collection of <see cref="TimeTrigger"/>s
    /// </summary>
    public ICollection<TimeTrigger> TimeTriggers { get; set; } = new List<TimeTrigger>();

    /// <summary>
    /// A collection of <see cref="LocationTrigger"/>
    /// </summary>
    public ICollection<LocationTrigger> LocationTriggers { get; set; } = new List<LocationTrigger>();
}
