using Core.Persistance.Repositories;

namespace Education.Domain.Entities
{
    public class Subject : Entity
    {
        public string Name { get; set; }
        
        public bool IsActive { get; set; } = false;
        public int? LessonId { get; set; }
        public virtual Lesson? Lesson { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public ICollection<SubjectImageFile> SubjectImageFiles { get; set; }
        public ICollection<DocumentFile> DocumentFiles { get; set; }

        public Subject()
        { }

        public Subject(int id, string name, bool isActive, int lessonId)
        {
            Id = id;
            Name = name;
            IsActive = isActive;
            LessonId = lessonId;
        }
    }
}
