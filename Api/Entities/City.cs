using System.ComponentModel.DataAnnotations.Schema;
using Api.Entities.Abstract;

namespace Api.Entities
{
    [Table("cities")]
    public class City : AddressBase
    {
        [Column("country_id", Order = 1)]
        public int CountryId { get; set; }

        [ForeignKey(nameof(CountryId))]
        public virtual Country Country { get; set; }
    }
}