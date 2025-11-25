using EventMakerClassLibrary.Interfaces;
using EventMakerClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorEventMaker25InClass.Pages.Events
{
    public class EditEventModel : PageModel
    {
        [BindProperty]
        public Event Event { get; set; }

        private IEventRepository _repo;
        public EditEventModel(IEventRepository eventRepository)
        {
            _repo = eventRepository;
        }
        public void OnGet(int id)
        {
            Event = _repo.GetEvent(id);
        }

        public IActionResult OnPost()
        {
            _repo.UpdateEvent(Event);
            return RedirectToPage("Index");
        }
    }
}
