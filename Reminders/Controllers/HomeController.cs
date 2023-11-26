using Htmx;
using Microsoft.AspNetCore.Mvc;

namespace Reminders.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet, Route("")]
        public IActionResult Index()
        {
            return Request.IsHtmx()
            ? PartialView("Index")
            : View("Index");
        }
    }
}