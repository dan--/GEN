using System.Collections.Generic;
using GirlsEmpowermentNetwork.Models;

namespace GirlsEmpowermentNetwork.Services
{
    public interface IVolunteerService
    {
        List<Volunteer> GetAll();
    }

    public class VolunteersService : IVolunteerService
    {
        public List<Volunteer> GetAll()
        {
            return new List<Volunteer>
            {
                new Volunteer{FirstName = "Dan", MobileNumber = "8189256585"},
                new Volunteer{FirstName = "Dre", MobileNumber = "2142408305"}
            };
        }
    }
}
