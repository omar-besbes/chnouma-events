using chnouma_events.Data;
using Microsoft.AspNetCore.Mvc;

namespace chnouma_events.Controllers;

[Route("calendar")]
public class CalendarController : Controller
{
    private readonly ICalendarRepository _repository;

    public CalendarController(CalendarContext context)
    {
        _repository = new CalendarRepository(context);
    }

    [HttpGet]
    public IActionResult Index()
    {
        var events = _repository.GetAllEvents();
        return View(events);
    }
}