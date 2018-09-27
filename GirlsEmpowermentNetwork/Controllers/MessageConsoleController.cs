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
        private readonly IMessageSenderService _messageSenderService;
        private readonly IVolunteerService _volunteerService;
        private readonly IEventService _eventService;

        public MessageConsoleController(ITemplateService templateService, IMessageSenderService messageSenderService,
            IVolunteerService volunteerService, IEventService eventService)
        {
            _templateService = templateService;
            _messageSenderService = messageSenderService;
            _volunteerService = volunteerService;
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

        [Route("[controller]/[action]/{eventId}")]
        public IActionResult SendAll(MessageConsoleViewModel messageConsoleViewModel)
        {
            var eventId = messageConsoleViewModel.EventId;
            var messageBody = messageConsoleViewModel.MessageBody;
            var volunteers = _volunteerService.GetVolunteersForEvent(eventId);
            _messageSenderService.SendNewMessage(messageBody, volunteers);
            return View();
        }
    }
}