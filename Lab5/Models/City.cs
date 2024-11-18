using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab5.Models;

[Table("cities")]
public class City
{
    [Key]
    [Column("city_id")]
    public int CityId { get; set; }

    [Required]
    [MaxLength(100)]
    [Column("city_name")]
    public string CityName { get; set; }

    [Required]
    [MaxLength(10)]
    [Column("area_code")]
    public string AreaCode { get; set; }

    public ICollection<Tariff> Tariffs { get; set; }
    public ICollection<Call> Calls { get; set; }
}