using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace chnouma_events.Models;

[Table("club")]
public class Club
{
    private static int _nextId = 0;

    [Key] [Column("id")] public int Id { get; private set; }

    [Required]
    [StringLength(32)]
    [Column("name")]
    public string Name { get; set; }

    [Column("description")] public string Description { get; set; }

    [Required] [NotMapped] public virtual List<User> Members { get; set; }
    
    [Required] [ForeignKey("university")] public int UniversityId { get; set; }
    public virtual University University { get; set; }

    [Required] [ForeignKey("calendar")] public int CalendarId { get; set; }
    public virtual Calendar Calendar { get; set; }
}