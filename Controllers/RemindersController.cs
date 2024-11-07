using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reminders.Data;
using Reminders.Data.Models;

namespace Reminders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RemindersController(ApplicationDbContext context) : ControllerBase
    {
        // GET: api/Reminders
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Reminder>>> GetReminder()
        {
            return await context.Reminder.Where(r => r.IsDeleted == false).ToListAsync();
        }

        // GET: api/Reminders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Reminder>> GetReminder(long id)
        {
            var reminder = await context.Reminder.FindAsync(id);

            if (reminder == null)
            {
                return NotFound();
            }

            return reminder;
        }

        // PUT: api/Reminders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReminder(long id, Reminder reminder)
        {
            if (id != reminder.Id)
            {
                return BadRequest();
            }

            context.Entry(reminder).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReminderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Reminders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Reminder>> PostReminder(Reminder reminder)
        {
            context.Reminder.Add(reminder);
            await context.SaveChangesAsync();

            return CreatedAtAction("GetReminder", new { id = reminder.Id }, reminder);
        }

        // DELETE: api/Reminders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReminder(long id)
        {
            var reminder = await context.Reminder.FindAsync(id);
            if (reminder == null)
            {
                return NotFound();
            }

            context.Reminder.Remove(reminder);
            await context.SaveChangesAsync();

            return NoContent();
        }

        private bool ReminderExists(long id)
        {
            return context.Reminder.Any(e => e.Id == id);
        }
    }
}
