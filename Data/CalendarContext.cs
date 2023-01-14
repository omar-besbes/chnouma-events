using chnouma_events.Models;
using Microsoft.EntityFrameworkCore;

namespace chnouma_events.Data;

public class CalendarContext : DbContext
{
    public DbSet<Calendar> Calendars { get; set; }

    public DbSet<User> Users { get; set; }

    public DbSet<Club> Clubs { get; set; }

    public DbSet<Event> Events { get; set; }

    public DbSet<University> Universities { get; set; }

    public CalendarContext(DbContextOptions<CalendarContext> options) : base(options)
    {
    }
}