using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab5.Models;

[Table("phones")]
public class Phone
{
    [Key]
    [Column("phone_id")]
    public int PhoneId { get; set; }

    [ForeignKey("Subscriber")]
    [Column("subscriber_id")]
    public int SubscriberId { get; set; }
    public Subscriber Subscriber { get; set; }

    [Required]
    [MaxLength(15)]
    [Column("phone_number")]
    public string PhoneNumber { get; set; }

    public ICollection<Call> Calls { get; set; }
}