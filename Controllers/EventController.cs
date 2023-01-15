using System.Runtime.InteropServices.JavaScript;
using chnouma_events.Data;
using chnouma_events.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace chnouma_events.Controllers;
[Route("event")]
public class EventController : Controller
{
    private readonly ICalendarRepository _repository;
    private readonly CalendarContext _context;
    public EventController(CalendarContext context)
    {
        _repository = new CalendarRepository(context);
        _context = context;
    }
    public IActionResult Index()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Create(Event e)
    {
        Console.WriteLine("yess we are here adding a new event "+e.Name+" "+e.StartDate+" "+e.EndDate+" "+e.Description);
        //_repository.AddEvent(e);
        return View(e);
    }
    
    [Route("add")]
    public IActionResult Add()
    {
        return View();
    }
    
    [HttpPost, ActionName("Edit")]
    [ValidateAntiForgeryToken]
    [Route("Events/edit")]
    public async Task<IActionResult> EditPost(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var eventToUpdate = await _context.Events.FirstOrDefaultAsync(e => e.Id == id);
        if (await TryUpdateModelAsync<Event>(
                eventToUpdate,
                "",
                e => e.Name, e => e.Description, e => e.StartDate, e=>e.EndDate))
        {
            try
            {
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.)
                ModelState.AddModelError("", "Unable to save changes. " +
                                             "Try again, and if the problem persists, " +
                                             "see your system administrator.");
            }
        }
        return Index();
    }
}