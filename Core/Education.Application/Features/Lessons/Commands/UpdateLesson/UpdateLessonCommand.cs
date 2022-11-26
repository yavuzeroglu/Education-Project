using Education.Application.Features.Lessons.DTOs;
using MediatR;

namespace Education.Application.Features.Lessons.Commands.UpdateLesson
{
    public class UpdateLessonCommand : IRequest<UpdateLessonDto>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CourseId { get; set; }
    }
}
