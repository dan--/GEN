using System.Collections.Generic;
using GirlsEmpowermentNetwork.Models;

namespace GirlsEmpowermentNetwork.Repositories
{
    public interface IEventRepository
    {
        IEnumerable<Event> Events();
    }

    public class EventRepository : IEventRepository
    {
        public IEnumerable<Event> Events()
        {
            return new List<Event>
            {
                new Event
                {
                    Id = "event-1",
                    Name = "We Are Girls Austin VLC Meeting",
                    Time= "10am – 11am",
                    Details= "The We Are Girls Austin 2018 Volunteer Leadership Committee convenes for final preparation before leading volunteer force on November 3rd",
                },
                new Event
                {
                    Id = "event-1",
                    Name = "We Are Girls Austin Volunteer Training",
                    Time= " 10am – 11am",
                    Details= "We Are Girls Austin 2018 volunteers join for a training on the layout of the school, their roles, and other key event information.",

                },
                new Event
                {
                    Id = "event-1",
                    Name = "GALeria Shopping Event",
                    Time= " 1pm - 4pm",
                    Details= "Girl Advocacy League hosts a craft market featuring local women makers"
                }
            };
        }
    }
}
