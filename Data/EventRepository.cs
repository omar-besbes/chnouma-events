using chnouma_events.Models;

namespace chnouma_events.Data;

public interface IEventRepository : IDisposable
{
    public void AddEvent(Event e);
    public void UpdateEvent(Event e);
    public void RemoveEvent(int id);
    public void Save();
}

public class EventRepository : IEventRepository
{
    private readonly CalendarContext _context;

    public EventRepository(CalendarContext context)
    {
        _context = context;
    }

    public void AddEvent(Event e)
    {
        throw new NotImplementedException();
    }

    public void UpdateEvent(Event e)
    {
        throw new NotImplementedException();
    }

    public void RemoveEvent(int id)
    {
        throw new NotImplementedException();
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