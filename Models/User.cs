using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace chnouma_events.Models;

[Table("user")]
public class User
{
    private static int _nextId = 0;

    [Key] [Column("id")] public int Id { get; private set; }

    [Required]
    [StringLength(32)]
    [Column("first_name")]
    public string FirstName { get; set; }

    [Required]
    [StringLength(32)]
    [Column("last_name")]
    public string LastName { get; set; }

    [Required]
    [StringLength(8)]
    [Column("phone_number")]
    public string PhoneNumber { get; set; }

    [Required] [NotMapped] public virtual University University { get; set; }

    [Required] [NotMapped] public virtual List<Club> Clubs { get; set; }

    [Required] [NotMapped] public virtual Calendar Calendar { get; set; }
}