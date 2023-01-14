using System.Data.SQLite;
using chnouma_events.Models;

namespace chnouma_events.Data;

public interface ICalendarRepository : IDisposable
{
    public IEnumerable<Event> GetAllEvents();
    public IEnumerable<Event> GetAllUniversityEvents(string university);
    public void Save();
}

public class CalendarRepository : ICalendarRepository
{
    private readonly CalendarContext _context;

    public CalendarRepository(CalendarContext context)
    {
        _context = context;
    }

    public IEnumerable<Event> GetAllEvents()
    {
        return _context.Events.ToList();
    }

    public IEnumerable<Event> GetAllUniversityEvents(string university)
    {
        var events = _context.Universities
            .Join(_context.Calendars,
                uni => uni.Id,
                cal => cal.Id,
                (uni, cal) => new
                {
                    CalendarId = cal.Id,
                    UniversityId = uni.Id,
                }
            ).Join(_context.Events,
                uniWithCal => uniWithCal.CalendarId,
                e => e.Id,
                (uniWithCal, e) => e
            );
        return events;
    }

    public void Save()
    {
        _context.SaveChanges();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}