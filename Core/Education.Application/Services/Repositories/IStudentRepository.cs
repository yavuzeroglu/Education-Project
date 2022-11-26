using Core.Persistance.Repositories;
using Education.Domain.Entities;

namespace Education.Application.Services.Repositories
{
    public interface IStudentRepository : IAsyncRepository<Student>, IRepository<Student>
    {
    }
}
