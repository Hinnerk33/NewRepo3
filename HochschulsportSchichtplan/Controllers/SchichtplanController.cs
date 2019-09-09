using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HochschulsportSchichtplan.Models;
using Microsoft.IdentityModel;
using HochschulsportSchichtplan.Data;
using Microsoft.AspNetCore.Authorization;
using HochschulsportSchichtplan.DataAccessLayer;
using System.Diagnostics;

using Microsoft.Extensions.Options;

namespace HochschulsportSchichtplan.Controllers
{
    public class SchichtplanController : Controller
    {
        private DA _DA { get; set; }

        public SchichtplanController(IOptions<AppSettings> settings)
        {
            _DA = new DA(settings.Value.ConnectionStr);
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetCalendarEvents(string start, string end)
        {
            List<Event> events = _DA.GetCalendarEvents(start, end);

            return Json(events);
        }

        [HttpPost]
        public IActionResult UpdateEvent([FromBody] Event evt)
        {
            string message = String.Empty;

            message = _DA.UpdateEvent(evt);

            return Json(new { message });
        }

        [HttpPost]
        public IActionResult AddEvent([FromBody] Event evt)
        {
            string message = String.Empty;
            int eventId = 0;

            message = _DA.AddEvent(evt, out eventId);

            return Json(new { message, eventId });
        }

        [HttpPost]
        public IActionResult DeleteEvent([FromBody] Event evt)
        {
            string message = String.Empty;

            message = _DA.DeleteEvent(evt.EventId);

            return Json(new { message });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}