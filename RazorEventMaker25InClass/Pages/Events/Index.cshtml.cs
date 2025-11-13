using EventMakerClassLibrary.Interfaces;
using EventMakerClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorEventMaker25InClass.Pages.Events
{
    public class IndexModel : PageModel
    {
        private IEventRepository _repo;

        public List<Event> Events { get; set; }

        public IndexModel(IEventRepository eventRepository)
        {
            _repo = eventRepository;
        }

        public void OnGet()
        {
            Events = _repo.GetAllEvents();
        }
    }
}
