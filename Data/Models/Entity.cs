using Microsoft.EntityFrameworkCore;

namespace Reminders.Data.Models;

/// <summary>
/// Encapulates regular entity behaviour
/// </summary>
[Index(nameof(IsDeleted))]
public class Entity
{
    /// <summary>
    /// Is the entity soft deleted?
    /// </summary>
    public bool IsDeleted { get; set; }

    /// <summary>
    /// When the entity was last soft deleted. See audits for full records
    /// </summary>
    public DateTimeOffset? DeletedAt { get; set; }

    /// <summary>
    /// Reinstates the entity to a non deleted state
    /// </summary>
    public void Undo()
    {
        IsDeleted = false;
        DeletedAt = null;
    }
}
