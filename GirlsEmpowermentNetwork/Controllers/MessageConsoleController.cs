using System.Collections.Generic;
using System.Linq;
using GirlsEmpowermentNetwork.Models;
using GirlsEmpowermentNetwork.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GirlsEmpowermentNetwork.Controllers
{
    public class MessageConsoleController : Controller
    {
        private readonly ITemplateService _templateService;
        private readonly IEventService _eventService;

        public MessageConsoleController(ITemplateService templateService, IEventService eventService)
        {
            _templateService = templateService;
            _eventService = eventService;
        }

        [Route("[controller]/{eventId}")]
        public IActionResult Index(string eventId)
        {
            var @event = _eventService.GetById(eventId);

            var templateNames = _templateService.GetAllTemplateNames();

            var model = new MessageConsoleViewModel
            {
                EventId = eventId,
                EventName = @event.Name,
                TemplateNames = templateNames
            };

            return View(model);
        }

        public IActionResult SendAll()
        {
            return View();
        }
    }
}