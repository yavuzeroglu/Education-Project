using Core.Persistance.Repositories;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using Education.Persistance.Contexts;


namespace Education.Persistance.Repositories
{
    public class CourseRepository : EfRepositoryBase<Course, EducationDbContext>, ICourseRepository
    {
        public CourseRepository(EducationDbContext context) : base(context)
        {
        }
    }
}
