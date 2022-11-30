namespace Education.Domain.Entities
{
    public class SubjectImageFile : File
    {
        public ICollection<Subject> Subjects { get; set; }
    }
}
