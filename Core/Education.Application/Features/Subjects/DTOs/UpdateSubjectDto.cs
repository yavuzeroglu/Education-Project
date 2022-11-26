namespace Education.Application.Features.Subjects.DTOs
{
    public class UpdateSubjectDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LessonId { get; set; }
    }
}
