using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab5.Models;

[Table("subscribers")]
public class Subscriber
{
    [Key]
    [Column("subscriber_id")]
    public int SubscriberId { get; set; }

    [Required]
    [MaxLength(100)]
    [Column("first_name")]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(100)]
    [Column("last_name")]
    public string LastName { get; set; }

    [MaxLength(100)]
    [Column("middle_name")]
    public string MiddleName { get; set; }

    [Required]
    [MaxLength(255)]
    [Column("address")]
    public string Address { get; set; }

    public ICollection<Phone> Phones { get; set; }
}