using Reminders.Reminders.Models;

namespace Reminders.Reminders.Interfaces
{
    public interface IReminderService
    {
        bool CreateReminder(Reminder reminder);
        IReadOnlyCollection<Reminder> GetReminders();
        bool DeleteReminder(int id);
        bool UpdateReminder(Reminder reminder);
    }
}