using System;
using System.Collections.Generic;
using System.Linq;
using GirlsEmpowermentNetwork.Models;
using GirlsEmpowermentNetwork.Repositories;

namespace GirlsEmpowermentNetwork.Services
{
    public interface IEventService
    {
        IEnumerable<Event> GetAll();
        Event GetById(string eventId);
    }

    public class EventService:IEventService
    {
        private readonly IEventRepository _eventRepository;

        public EventService(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public IEnumerable<Event> GetAll()
        {
            return _eventRepository.Events();
        }

        public Event GetById(string eventId)
        {
            var template = _eventRepository.Events().SingleOrDefault(e => string.Equals(e.Id, eventId, StringComparison.CurrentCultureIgnoreCase));

            return template;
        }
    }
}
