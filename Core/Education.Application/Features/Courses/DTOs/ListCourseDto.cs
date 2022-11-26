using Education.Domain.Entities;

namespace Education.Application.Features.Courses.DTOs
{
    public class ListCourseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IReadOnlyCollection<string>? Students { get; set; }
        public IReadOnlyCollection<string>? Lessons { get; set; }
    }
}
