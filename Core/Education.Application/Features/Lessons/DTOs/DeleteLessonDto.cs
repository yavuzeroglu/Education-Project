namespace Education.Application.Features.Lessons.DTOs
{
    public class DeleteLessonDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CourseId { get; set; }
    }
}
