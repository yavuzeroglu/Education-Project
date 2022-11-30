using Core.Persistance.Repositories;

namespace Education.Domain.Entities
{
    public class File : Entity
    {
        public string FileName { get; set; }
        public string Path { get; set; }
    }
}
