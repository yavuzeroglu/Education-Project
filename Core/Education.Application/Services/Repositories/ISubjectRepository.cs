using Core.Persistance.Repositories;
using Education.Domain.Entities;

namespace Education.Application.Services.Repositories
{
    public interface ISubjectRepository : IAsyncRepository<Subject>, IRepository<Subject>
    {
        
    }
}
