using Core.Persistance.Repositories;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using Education.Persistance.Contexts;

namespace Education.Persistance.Repositories
{
    public class QuestionRepository : EfRepositoryBase<Question, EducationDbContext>, IQuestionRepository
    {
        public QuestionRepository(EducationDbContext context) : base(context)
        {
        }
    }
}
