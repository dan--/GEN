using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GirlsEmpowermentNetwork.Services;
using Microsoft.AspNetCore.Mvc;

namespace GirlsEmpowermentNetwork.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        public IActionResult Index()
        {
            var list = _eventService.GetAll();
            return View(list);
        }
    }
}