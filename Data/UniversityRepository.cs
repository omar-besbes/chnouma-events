using chnouma_events.Models;

namespace chnouma_events.Data;

public interface IUniversityRepository : IDisposable
{
    IEnumerable<University> GetUniversities();
    University GetUniversityById(int id);
    void InsertUniversity(University university);
    void DeleteUniversity(int studentId);
    void UpdateUniversity(University student);
    void Save();
}

public class UniversityRepository : IUniversityRepository
{
    private readonly CalendarContext _context;

    public UniversityRepository(CalendarContext context)
    {
        _context = context;
    }

    public IEnumerable<University> GetUniversities()
    {
        throw new NotImplementedException();
    }

    public University GetUniversityById(int id)
    {
        throw new NotImplementedException();
    }

    public void InsertUniversity(University university)
    {
        throw new NotImplementedException();
    }

    public void DeleteUniversity(int studentId)
    {
        throw new NotImplementedException();
    }

    public void UpdateUniversity(University student)
    {
        throw new NotImplementedException();
    }

    public void Save()
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}