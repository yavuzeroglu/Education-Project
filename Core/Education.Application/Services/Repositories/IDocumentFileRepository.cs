using Core.Persistance.Repositories;
using Education.Domain.Entities;

namespace Education.Application.Services.Repositories
{
    public interface IDocumentFileRepository : IAsyncRepository<DocumentFile>, IRepository<DocumentFile> { }
}
