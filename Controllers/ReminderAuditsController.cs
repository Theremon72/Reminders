using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reminders.Data;
using Reminders.Data.Models;

namespace Reminders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReminderAuditsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ReminderAuditsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ReminderAudits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReminderAudit>>> GetreminderAudits()
        {
            return await _context.ReminderAudits.ToListAsync();
        }

        // GET: api/ReminderAudits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ReminderAudit>> GetReminderAudit(long id)
        {
            var reminderAudit = await _context.ReminderAudits.FindAsync(id);

            if (reminderAudit == null)
            {
                return NotFound();
            }

            return reminderAudit;
        }

        // PUT: api/ReminderAudits/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReminderAudit(long id, ReminderAudit reminderAudit)
        {
            if (id != reminderAudit.Id)
            {
                return BadRequest();
            }

            _context.Entry(reminderAudit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReminderAuditExists(id))
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

        // POST: api/ReminderAudits
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ReminderAudit>> PostReminderAudit(ReminderAudit reminderAudit)
        {
            _context.ReminderAudits.Add(reminderAudit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReminderAudit", new { id = reminderAudit.Id }, reminderAudit);
        }

        // DELETE: api/ReminderAudits/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReminderAudit(long id)
        {
            var reminderAudit = await _context.ReminderAudits.FindAsync(id);
            if (reminderAudit == null)
            {
                return NotFound();
            }

            _context.ReminderAudits.Remove(reminderAudit);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ReminderAuditExists(long id)
        {
            return _context.ReminderAudits.Any(e => e.Id == id);
        }
    }
}
