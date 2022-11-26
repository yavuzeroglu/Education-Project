using Core.Persistance.Repositories;

namespace Education.Domain.Entities
{
    public class Lesson : Entity
    {
        public string Name { get; set; }
        public bool IsActive { get; set; } = false;
        public int? CourseId { get; set; }
        public virtual Course? Course { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }


        public Lesson()
        { }

        public Lesson(int id, string name, bool isActive, int courseId)
        {
            Id = id;
            Name = name;
            IsActive = isActive;
            CourseId = courseId;

        }
    }
}
