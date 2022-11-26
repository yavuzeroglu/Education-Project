using Core.Persistance.Repositories;
using Education.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Application.Services.Repositories
{
    public interface ILessonRepository : IAsyncRepository<Lesson>, IRepository<Lesson> 
    {
    }
}
