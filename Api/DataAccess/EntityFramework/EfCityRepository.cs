﻿using Api.DataAccess.Abstract;
using Api.DataAccess.EntityFramework.Persistence;
using Api.Entities;

namespace Api.DataAccess.EntityFramework
{
    public class EfCityRepository : EfRepositoryBase<City, int>, ICityRepository
    {
        public EfCityRepository(GeolocationDbContext dbContext) : base(dbContext)
        {
        }
    }
}