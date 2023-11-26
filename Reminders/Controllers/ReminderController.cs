using Microsoft.AspNetCore.Mvc;
using Reminders.Reminders.Interfaces;
using Reminders.Reminders.Models;

namespace Reminders.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReminderController : ControllerBase
    {
        private readonly ILogger<ReminderController> _logger;
        private readonly IReminderService _reminderService;

        public ReminderController(ILogger<ReminderController> logger, IReminderService reminderService)
        {
            _logger = logger;
            _reminderService = reminderService;
        }

        [HttpPost("CreateReminder")]
        public ActionResult CreateReminder([FromBody] Reminder reminder)
        {
            var result = _reminderService.CreateReminder(reminder);
            return Ok(result);
        }

        [HttpGet("GetReminders")]
        public ActionResult GetReminders()
        {
            var reminders = _reminderService.GetReminders();

            return Ok(reminders);
        }

        [HttpPost("DeleteReminder")]
        public ActionResult DeleteReminder([FromBody] int id)
        {
            var result = _reminderService.DeleteReminder(id);
            return Ok(result);
        }

        [HttpPost("UpdateReminder")]
        public ActionResult UpdateReminder([FromBody] Reminder reminder)
        {
            var result = _reminderService.UpdateReminder(reminder);
            return Ok(result);
        }
    }
}