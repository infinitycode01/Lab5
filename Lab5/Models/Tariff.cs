using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab5.Models;

[Table("tariffs")]
public class Tariff
{
    [Key]
    [Column("tariff_id")]
    public int TariffId { get; set; }

    [ForeignKey("City")]
    [Column("city_id")]
    public int CityId { get; set; }
    public City City { get; set; }

    [Required]
    [Column("rate_per_minute", TypeName = "numeric(10,2)")]
    public decimal RatePerMinute { get; set; }

    public ICollection<Call> Calls { get; set; }
}