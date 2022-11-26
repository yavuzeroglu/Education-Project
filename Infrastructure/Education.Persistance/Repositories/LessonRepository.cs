using Core.Persistance.Repositories;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using Education.Persistance.Contexts;

namespace Education.Persistance.Repositories
{
    public class LessonRepository : EfRepositoryBase<Lesson, EducationDbContext>, ILessonRepository
    {
        public LessonRepository(EducationDbContext context) : base(context)
        {
        }
    }
}
