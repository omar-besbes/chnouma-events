using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace chnouma_events.Models;

public class Event
{
    private static int _nextId = 0;
    
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    [Column("name")]
    public string Name { get; set; }
    
    [Column("description")]
    public string Description { get; set; }
    
    [Required]
    public virtual Club HostClub { get; set; }

    [Required]
    [DataType(DataType.Date)]
    [Column("start_date")]
    public DateTime StartDate { get; set; }

    [Required]
    [DataType(DataType.Date)]
    [Column("end_date")]
    public DateTime EndDate { get; set; }
}