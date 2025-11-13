using EventMakerClassLibrary.Interfaces;
using EventMakerClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorEventMaker25InClass.Pages.Events
{
    public class CreateEventModel : PageModel
    {
        private IEventRepository _repo;


        //Den nye event hentes ind i NewEvent
        [BindProperty]
        public Event NewEvent { get; set; }
        public CreateEventModel(IEventRepository eventRepository  )
        {
            _repo = eventRepository;
        }

        //Kaldes når der skal hentes/vises noget
        public void OnGet()
        {
        }

        //Når der skal ændres noget
        public IActionResult OnPost()
        {
            _repo.AddEvent(NewEvent);
            return RedirectToPage("Index");
        }
    }
}
