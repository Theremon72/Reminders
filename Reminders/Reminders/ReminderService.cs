using Reminders.Database;
using Reminders.Reminders.Interfaces;
using Reminders.Reminders.Models;

namespace Reminders.Reminders
{
    public class ReminderService : IReminderService
    {
        private readonly ILogger<ReminderService> _logger;
        private readonly ReminderContext _context;
        public ReminderService(ILogger<ReminderService> logger, ReminderContext context)
        {
            _logger = logger;
            _context = context;
        }

        public bool CreateReminder(Reminder reminder)
        {
            var entity = _context.Reminders.Add(reminder);
            if (entity == null)
            {
                return false;
            }
            var saved = _context.SaveChanges();
            if (saved == 0)
            {
                return false;
            }
            return true;
        }

        public bool DeleteReminder(int id)
        {
            var reminder = _context.Reminders.Find(id);
            if (reminder == null)
            {
                return false;
            }
            _context.Reminders.Remove(reminder);
            var saved = _context.SaveChanges();
            if (saved == 0)
            {
                return false;
            }
            return true;
        }

        public IReadOnlyCollection<Reminder> GetReminders()
        {
            return _context.Reminders.ToList();
        }

        public bool UpdateReminder(Reminder reminder)
        {
            var reminderToUpdate = _context.Reminders.Find(reminder.Id);
            if (reminderToUpdate == null)
            {
                return false;
            }

            reminderToUpdate.Date = reminder.Date;
            reminderToUpdate.Time = reminder.Time;
            reminderToUpdate.SnoozeInterval = reminder.SnoozeInterval;
            reminderToUpdate.ReReminderInterval = reminder.ReReminderInterval;
            reminderToUpdate.DaySchedule = reminder.DaySchedule;
            reminderToUpdate.Note = reminder.Note;

            var saved = _context.SaveChanges();
            if (saved == 0)
            {
                return false;
            }
            return true;
        }
    }
}
