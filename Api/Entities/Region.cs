using System.ComponentModel.DataAnnotations.Schema;
using Api.Entities.Abstract;

namespace Api.Entities
{
    [Table("regions")]
    public class Region : AddressBase
    {
        [Column("continental_id", Order = 1)]
        public int ContinentalId { get; set; }

        [ForeignKey(nameof(ContinentalId))]
        public virtual Continental Continental { get; set; }
    }
}