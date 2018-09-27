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

        public MessageConsoleController(ITemplateService templateService)
        {
            _templateService = templateService;
        }

        [Route("{controller}/{eventId}")]
        public IActionResult Index(string eventId)
        {
            var templateNames = _templateService.GetAllTemplateNames();

            var model = new MessageConsoleViewModel
            {
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