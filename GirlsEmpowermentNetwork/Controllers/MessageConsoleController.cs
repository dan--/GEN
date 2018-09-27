using GirlsEmpowermentNetwork.Models;
using GirlsEmpowermentNetwork.Services;
using Microsoft.AspNetCore.Mvc;

namespace GirlsEmpowermentNetwork.Controllers
{
    public class MessageConsoleController : Controller
    {
        private readonly ITemplateService _templateService;

        public MessageConsoleController(ITemplateService templateService)
        {
            _templateService = templateService;
        }

        public IActionResult Index()
        {
            var templateNames = _templateService.GetAllTemplateNames();

            var model = new MessageConsoleViewModel
            {
                TemplateNames = templateNames
            };

            return View();
        }
    }
}