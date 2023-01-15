using System.Data.SQLite;
using chnouma_events.Models;

namespace chnouma_events.Data;

public interface ICalendarRepository : IDisposable
{
    public IEnumerable<Event> GetAllEvents();
    public IEnumerable<Event> GetAllUniversityEvents(string university);
    public IEnumerable<Event> GetAllClubEvents(int id);
    public IEnumerable<Event> GetAllUserEvents(int id);
    public void AddEvent(Event e);
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
    
    public IEnumerable<Event> GetAllClubEvents(int club)
    {
        var events = _context.Clubs
            .Join(_context.Calendars,
                club => club.Id,
                cal => cal.Id,
                (club, cal) => new
                {
                    CalendarId = cal.Id,
                    ClubId = club.Id,
                }
            ).Join(_context.Events,
                clubWithCal => clubWithCal.CalendarId,
                e => e.Id,
                (clubWithCal, e) => e
            );
        return events;
    }
    
    public IEnumerable<Event> GetAllUserEvents(int id)
    {
        var events = _context.Users
            .Join(_context.Calendars,
                user => user.Id,
                cal => cal.Id,
                (user, cal) => new
                {
                    CalendarId = cal.Id,
                    UserId = user.Id,
                }
            ).Join(_context.Events,
                userWithCal => userWithCal.CalendarId,
                e => e.Id,
                (userWithCal, e) => e
            );
        return events;
    }

    public void AddEvent(Event e)
    {
        _context.Events.Add(e);
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