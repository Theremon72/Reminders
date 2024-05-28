namespace Reminders.Data.Models;


/// <summary>
/// This represents where to trigger a locational <see cref="Reminder"/>
/// </summary>
public class LocationTrigger : Entity
{
    public long Id { get; set; }
    public long ReminderId { get; set; }

    /// <summary>
    /// Indicates this time trigger should be removed once completed
    /// </summary>
    public bool IsTemporary { get; set; }

    public float Latitude { get; set; }
    public float Longitude { get; set; }

    /// <summary>
    /// The range from the position to trigger the alarm.
    /// </summary>
    public int Range { get; set; }

    /// <summary>
    /// Indicates a delay once the position is reached to fire the trigger.
    /// </summary>
    public TimeSpan Delay { get; set; }
}
