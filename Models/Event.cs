using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace chnouma_events.Models;

[Table("event")]
public class Event
{
    private static int _nextId = 0;

    [Key] [Column("id")] public int Id { get; private set; }

    [Required]
    [StringLength(100)]
    [Column("name")]
    public string Name { get; set; }

    [Column("description")] public string Description { get; set; }

    [Required]
    [DataType(DataType.DateTime)]
    [Column("start_date")]
    public DateTime StartDate { get; set; }

    [Required]
    [DataType(DataType.DateTime)]
    [Column("end_date")]
    public DateTime EndDate { get; set; }

    [Required] [NotMapped] public virtual List<Tag> Tags { get; set; }
}