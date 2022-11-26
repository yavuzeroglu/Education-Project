using Education.Application.Features.Lessons.DTOs;
using MediatR;

namespace Education.Application.Features.Lessons.Commands.CreateLesson
{
    public class CreateLessonCommand : IRequest<CreateLessonDto>
    {
        public string Name { get; set; }
        public int CourseId { get; set; }
    }
}
