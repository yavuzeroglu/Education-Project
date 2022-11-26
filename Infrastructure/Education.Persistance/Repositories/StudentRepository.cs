using Core.Persistance.Repositories;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using Education.Persistance.Contexts;

namespace Education.Persistance.Repositories
{
    public class StudentRepository : EfRepositoryBase<Student, EducationDbContext>, IStudentRepository
    {
        public StudentRepository(EducationDbContext context) : base(context)
        { }
    }
}
