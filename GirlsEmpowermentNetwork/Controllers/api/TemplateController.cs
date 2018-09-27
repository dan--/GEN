using System.Collections.Generic;
using GirlsEmpowermentNetwork.Models;
using GirlsEmpowermentNetwork.Services;
using Microsoft.AspNetCore.Mvc;

namespace GirlsEmpowermentNetwork.Controllers.api
{
    [Route("api/templates")]
    [ApiController]

    public class TemplateController
    {
        private readonly ITemplateService _templateService;

        public TemplateController(ITemplateService templateService)
        {
            _templateService = templateService;
        }

        public IEnumerable<string> Get()
        {
            return _templateService.GetAllTemplateNames();
        }

//        [Route("api/templates/{name}")]
        [HttpGet("{name}")]
        public Template Get(string name)
        {
            var template = _templateService.GetTemplateByName(name);
            return template;
        }
    }
}
