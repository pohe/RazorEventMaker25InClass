using EventMakerClassLibrary.Interfaces;
using EventMakerClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorEventMaker25InClass.Pages.Events
{
	public class DeleteEventModel : PageModel
	{
		[BindProperty]
		public Event Event { get; set; }

		private IEventRepository _repo;
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
