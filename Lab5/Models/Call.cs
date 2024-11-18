using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab5.Models;

[Table("calls")]
public class Call
{
    [Key]
    [Column("call_id")]
    public int CallId { get; set; }

    [ForeignKey("Phone")]
    [Column("phone_id")]
    public int PhoneId { get; set; }
    public Phone Phone { get; set; }

    [ForeignKey("City")]
    [Column("city_id")]
    public int CityId { get; set; }
    public City City { get; set; }

    [Column("call_date")]
    public DateTime CallDate { get; set; }
    
    [Column("call_duration")]
    public int CallDuration { get; set; }

    [ForeignKey("Tariff")]
    [Column("tariff_id")]
    public int TariffId { get; set; }
    public Tariff Tariff { get; set; }
}