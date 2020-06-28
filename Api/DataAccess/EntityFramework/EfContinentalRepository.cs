﻿using Api.DataAccess.Abstract;
using Api.DataAccess.EntityFramework.Persistence;
using Api.Entities;

namespace Api.DataAccess.EntityFramework
{
    public class EfContinentalRepository : EfRepositoryBase<Continental, int>, IContinentalRepository
    {
        public EfContinentalRepository(GeolocationDbContext dbContext) : base(dbContext)
        {
        }
    }
}