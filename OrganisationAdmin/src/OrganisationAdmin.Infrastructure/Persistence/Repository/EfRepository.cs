﻿using Ardalis.Specification.EntityFrameworkCore;
using LocalAuthorityInformationServices.SharedKernel.Interfaces;

namespace OrganisationAdmin.Infrastructure.Persistence.Repository
{
    // We are using the EfRepository from Ardalis.Specification
    // https://github.com/ardalis/Specification/blob/v5/ArdalisSpecificationEF/src/Ardalis.Specification.EF/RepositoryBaseOfT.cs
    public class EfRepository<T> : RepositoryBase<T>, IRepository<T> where T : class, IAggregateRoot
    {
        public EfRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
