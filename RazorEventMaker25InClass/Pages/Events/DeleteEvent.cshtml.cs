using EventMakerClassLibrary.Interfaces;
using EventMakerClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorEventMaker25InClass.Pages.Events
{
    public class DeleteEventModel : PageModel
    {
        private IEventRepository _repo;

        [BindProperty]
        public Event Event { get; set; }

        public DeleteEventModel(IEventRepository eventRepository)
        {
           _repo = eventRepository;
        }

        public void OnGet(int id)
        {
            Event = _repo.GetEvent(id);
        }

        public IActionResult OnPost()
        {

            _repo.DeleteEvent(Event);
            return RedirectToPage("Index");
        }

    }
}
