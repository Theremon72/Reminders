using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Reminders.Data.Models;

namespace Reminders.Data;
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Reminder> Reminder { get; set; } = default!;
    public DbSet<ReminderAudit> reminderAudits { get; set; } = default!;
}
