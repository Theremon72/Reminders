using Microsoft.Extensions.Logging;
using NSubstitute;
using Reminders.Database;

namespace Reminders.Reminders.Tests
{
    public class ReminderServiceTests
    {
        private readonly ReminderService _service;
        private readonly ReminderContext _dbcontext;

        public ReminderServiceTests()
        {
            var logger = Substitute.For<ILogger<ReminderService>>();
            _dbcontext = Substitute.For<ReminderContext>();
            _service = new ReminderService(logger, _dbcontext);
        }
    }
}