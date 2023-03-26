using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace chnouma_events.Models;

public class University
{
    private static int _nextId = 0;
    
    [Key]
    public int Id { get; set; }
    
    [Required]
    [StringLength(100)]
    [Column("name")]
    public string Name { get; set; }
    
    [Required]
    public virtual int CalendarId { get; set; }
    public virtual Calendar Calendar { get; set; }
}