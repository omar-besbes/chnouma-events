using chnouma_events.Data;
using chnouma_events.Models;
using Microsoft.AspNetCore.Mvc;

namespace chnouma_events.Controllers;

[Route("university")]
public class UniversityController : Controller
{
    private readonly IUniversityRepository _repository;
    
    public UniversityController(CalendarContext context)
    {
        _repository = new UniversityRepository(context);
    }
    
    // [HttpGet]
    // [Route("all")]
    // public IActionResult GetAll()
    // {
    //     var universities = this._repository.GetUniversities();
    //     return PartialView(universities);
    // }
}