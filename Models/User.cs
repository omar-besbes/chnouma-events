using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace chnouma_events.Models;

[Table("Student")]
public class User
{
    private static int _nextId = 0;

    [Key] 
    public int Id { get; set; }
    
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
    
    [Required]
    public virtual University University { get; set; }

    public User(string firstName, string lastName, string phoneNumber, string university)
    {
        Id = _nextId++;
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
    }
}