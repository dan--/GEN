using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GirlsEmpowermentNetwork.Controllers
{
    public class MessageConsoleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}