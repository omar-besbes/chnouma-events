using System.ComponentModel.DataAnnotations;

namespace chnouma_events.Models;

public class Calendar
{
    private static int _nextId = 0;
    
    [Key]
    public int Id { get; set; }
    
    [Required]
    public virtual University University { get; set; }
}