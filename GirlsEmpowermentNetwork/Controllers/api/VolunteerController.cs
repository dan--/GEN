using System.Collections.Generic;
using GirlsEmpowermentNetwork.Models;
using GirlsEmpowermentNetwork.Services;
using Microsoft.AspNetCore.Mvc;

namespace GirlsEmpowermentNetwork.Controllers.api
{
    [Route("api/volunteers")]
    [ApiController]
    public class VolunteerController : ControllerBase
    {
        private readonly IVolunteerService _volunteerService;

        public VolunteerController(IVolunteerService volunteerService)
        {
            _volunteerService = volunteerService;
        }

        public IEnumerable<Volunteer> Get()
        {
            var list = _volunteerService.GetAll();

            return list;
        }
    }
}