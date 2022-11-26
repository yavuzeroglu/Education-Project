using Core.Persistance.Repositories;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using Education.Persistance.Contexts;

namespace Education.Persistance.Repositories
{
    public class ExamRepository : EfRepositoryBase<Exam, EducationDbContext>, IExamRepository
    {
        public ExamRepository(EducationDbContext context) : base(context)
        {
        }
    }
}
