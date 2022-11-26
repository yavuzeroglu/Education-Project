using Core.Persistance.Repositories;

namespace Education.Domain.Entities
{
    public class Exam : Entity
    {
        public int SubjectId { get; set; }
        public virtual Subject? Subject { get; set; }
        public virtual ICollection<Course> Courses { get; set; }

        public Exam()
        { }

        public Exam(int id, int subjectId)
        {
            Id = id;
            SubjectId = subjectId;
        }
    }
}
