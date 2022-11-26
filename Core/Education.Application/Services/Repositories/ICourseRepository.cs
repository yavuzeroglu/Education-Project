using Core.Persistance.Repositories;
using Education.Domain.Entities;

namespace Education.Application.Services.Repositories
{
    public interface ICourseRepository : IAsyncRepository<Course>, IRepository<Course>
    {
    }
}
