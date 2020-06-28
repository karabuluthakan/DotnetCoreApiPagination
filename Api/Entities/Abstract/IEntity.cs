using System;

namespace Api.Entities.Abstract
{
    public interface IEntity
    {
    }

    public interface IEntity<TKey> : IEntity where TKey : IEquatable<TKey>
    {
        TKey Id { get; set; }
    }
}