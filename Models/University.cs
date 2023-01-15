using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace chnouma_events.Models;

[Table("university")]
public class University
{
    private static int _nextId = 0;

    [Key] [Column("id")] public int Id { get; private set; }

    [Required]
    [StringLength(100)]
    [Column("name")]
    public string Name { get; set; }

    [Required] [ForeignKey("calendar")] public virtual int CalendarId { get; set; }
    public virtual Calendar Calendar { get; set; }
    
    [Required] [ForeignKey("user")] public virtual List<User> Students { get; set; }
}