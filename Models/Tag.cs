using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace chnouma_events.Models;

public class Tag
{
    private static int _nextId = 0;
    
    [Key]
    public int Id { get; set; }
    
    [Required]
    [StringLength(12)]
    [Column("name")]
    public string Name { get; set; }
}