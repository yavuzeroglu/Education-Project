using Core.Persistance.Repositories;
using Education.Application.Services.Repositories;
using Education.Persistance.Contexts;

namespace Education.Persistance.Repositories
{
    public class FileRepository : EfRepositoryBase<Domain.Entities.File, EducationDbContext>, IFileRepository
    {
        public FileRepository(EducationDbContext context) : base(context)
        {
        }
    }
}
