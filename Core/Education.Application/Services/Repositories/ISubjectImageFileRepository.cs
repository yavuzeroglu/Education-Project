using Core.Persistance.Repositories;
using Education.Domain.Entities;

namespace Education.Application.Services.Repositories
{
    public interface ISubjectImageFileRepository : IAsyncRepository<SubjectImageFile>, IRepository<SubjectImageFile>
    {
        Task<bool> AddRangeAsync(List<SubjectImageFile> subjectImageFiles);
    }
}
