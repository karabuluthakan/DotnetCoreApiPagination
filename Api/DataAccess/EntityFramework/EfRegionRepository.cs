﻿using Api.DataAccess.Abstract;
using Api.DataAccess.EntityFramework.Persistence;
using Api.Entities;

namespace Api.DataAccess.EntityFramework
{
    public class EfRegionRepository : EfRepositoryBase<Region, int>, IRegionRepository
    {
        public EfRegionRepository(GeolocationDbContext dbContext) : base(dbContext)
        {
        }
    }
}