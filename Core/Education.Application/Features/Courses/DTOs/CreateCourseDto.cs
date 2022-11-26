namespace Education.Application.Features.Courses.DTOs
{
    public class CreateCourseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? StudentId { get; set; }
    }
}
