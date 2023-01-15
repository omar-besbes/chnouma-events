using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace chnouma_events.Models;

[Table("tag")]
public class Tag
{
    private static int _nextId = 0;

    [Key] [Column("id")] public int Id { get; private set; }

    [Required]
    [StringLength(12)]
    [Column("name")]
    public string Name { get; set; }

    [NotMapped] public virtual List<Event> TaggedEvents { get; set; }
}