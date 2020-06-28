﻿using Api.DataAccess.Abstract;
using Api.DataAccess.EntityFramework.Persistence;
using Api.Entities;

namespace Api.DataAccess.EntityFramework
{
    public class EfCountryRepository : EfRepositoryBase<Country, int>, ICountryRepository
    {
        public EfCountryRepository(GeolocationDbContext dbContext) : base(dbContext)
        {
        }
    }
}