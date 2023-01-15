using chnouma_events.Models;

namespace chnouma_events.Data;

public interface IUserRepository: IDisposable
{
    public void AddUser(User user);
    public void UpdateUser(User user);
    public void RemoveUser(int id);
    public void Save();
}

public class UserRepository : IUserRepository
{
    private readonly CalendarContext _context;

    public UserRepository(CalendarContext context)
    {
        _context = context;
    }
    
    public void AddUser(User user)
    {
        _context.Users.Add(user);
    }

    public void UpdateUser(User user)
    {
        throw new NotImplementedException();
    }

    public void RemoveUser(int id)
    {
        _context.Users.Remove(_context.Users.Find(id));
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