using Core.Persistance.Repositories;

namespace Education.Domain.Entities
{
    public class Course : Entity
    {
        public string Name { get; set; }
        public bool IsActive { get; set; } = false;
        
        // Exam Id ? 

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }



        public Course()
        { }

        public Course(int id, string name, bool isActive)
        {
            Id = id;
            Name = name;
            IsActive = isActive;
        }
    }
}
