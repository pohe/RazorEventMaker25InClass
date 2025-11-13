using EventMakerClassLibrary.Interfaces;
using EventMakerClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMakerClassLibrary.Services
{
    public class EventRepository : IEventRepository
    {
        private List<Event> _events;


        public EventRepository()
        {
            _events = new List<Event>();
            PopulateEventsWithTestData();
        }



        public void AddEvent(Event ev)
        {
            //TODO
            _events.Add(ev);
        }

        public void DeleteEvent(Event ev)
        {
            throw new NotImplementedException();
        }

        public List<Event> GetAllEvents()
        {
            return _events;
        }

        public Event GetEvent(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEvent(Event ev)
        {
            throw new NotImplementedException();
        }

        private void PopulateEventsWithTestData()
        {
            _events.Add(new Event()
            {
                Id = 1,
                Name = "Roskilde Festival",
                Description = "A lot of music",
                City = "Roskilde",
                DateTime = new DateTime(2026, 7, 1, 10, 0, 0)
            });
            _events.Add(new Event()
            {
                Id = 2,
                Name = "CPH Marathon",
                Description = "Many Marathon runners",
                City = "Copenhagen",
                DateTime = new DateTime(2026, 3, 6, 10, 0, 0)
            });
            _events.Add(new Event()
            {
                Id = 3,
                Name = "CPH Distorsion",
                Description = "A lot of beers",
                City = "Copenhagen",
                DateTime = new DateTime(2026, 6, 4, 14, 0, 0)
            });
            _events.Add(new Event()
            {
                Id = 4,
                Name = "Demo Day",
                Description = "Project Presentations",
                City = "Roskilde",
                DateTime = new DateTime(2026, 6, 9, 9, 0, 0)
            });
            _events.Add(new Event()
            {
                Id = 5,
                Name = "VM Badminton",
                Description = "Badminton",
                City = "Århus",
                DateTime = new DateTime(2026, 10, 3, 16, 0, 0)
            });
        }
    }


}
