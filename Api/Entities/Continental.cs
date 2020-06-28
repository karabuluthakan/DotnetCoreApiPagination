using System.ComponentModel.DataAnnotations.Schema;
using Api.Entities.Abstract;

namespace Api.Entities
{
    [Table("continentals")]
    public class Continental : AddressBase
    {
    }
}