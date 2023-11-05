using Microsoft.EntityFrameworkCore;
using Reminders.Reminders.Models;

namespace Reminders.Database
{
    public class ReminderContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public ReminderContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(Configuration.GetConnectionString("RemindersDb"));

        public DbSet<Reminder> Reminders { get; set; }
    }
}
