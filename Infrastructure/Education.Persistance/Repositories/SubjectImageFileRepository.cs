﻿using Core.Persistance.Repositories;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using Education.Persistance.Contexts;

namespace Education.Persistance.Repositories
{
    public class SubjectImageFileRepository : EfRepositoryBase<SubjectImageFile, EducationDbContext>, ISubjectImageFileRepository
    {
        public SubjectImageFileRepository(EducationDbContext context) : base(context)
        {
        }
    }
}