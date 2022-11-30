using Core.Persistance.Repositories;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using Education.Persistance.Contexts;

namespace Education.Persistance.Repositories
{
    public class DocumentFileRepository : EfRepositoryBase<DocumentFile, EducationDbContext>, IDocumentFileRepository
    { 
        public DocumentFileRepository(EducationDbContext context) : base(context)
        {
        }
    }
}
