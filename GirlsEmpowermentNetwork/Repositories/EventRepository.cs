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
                    Name = "We Are Girls Austin VLC Meeting"
                },
                new Event
                {
                    Id = "event-2",
                    Name = "We Are Girls Austin Volunteer Training"
                },
                new Event
                {
                    Id = "event-3",
                    Name = "GALeria Shopping Event"
                },
                new Event
                {
                    Id = "event-4",
                    Name = "Volunteer Night: We Are Girls Austin Phone Bank"
                },
            };

        }
    }
}
