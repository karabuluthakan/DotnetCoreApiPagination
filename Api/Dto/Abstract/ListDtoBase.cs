using System;

namespace Api.Dto.Abstract
{
    public abstract class ListDtoBase : DtoBase
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}