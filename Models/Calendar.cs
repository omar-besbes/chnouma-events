using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace chnouma_events.Models;

[Table("calendar")]
public class Calendar
{
    private static int _nextId = 0;

    [Key] [Column("id")] public int Id { get; private set; }

    [Required] [ForeignKey("event")] public virtual List<Event> Events { get; set; }
}