using Api.Dto.Abstract;

namespace Api.Dto
{
    public class CountryListDto : ListDtoBase
    {
        public int RegionId { get; set; }
        public string Alpha2Code { get; set; }
        public string Alpha3Code { get; set; }
        public string UnCode { get; set; }
    }
}