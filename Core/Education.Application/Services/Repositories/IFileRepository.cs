using Core.Persistance.Repositories;

namespace Education.Application.Services.Repositories
{
    public interface IFileRepository : IAsyncRepository<Domain.Entities.File>, IRepository<Domain.Entities.File>
    {
    }
}
