using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace chnouma_events.Models;

public class Club
{
    private static int _nextId = 0;
    
    [Key]
    public int Id { get; set; }
    
    [Required]
    [StringLength(32)]
    [Column("name")]
    public string Name { get; set; }
    
    [Column("description")]
    public string Description { get; set; }
    
    [Required]
    public virtual List<User> Members { get; set; }
    
    [Required]
    public virtual Calendar Calendar { get; set; }
}