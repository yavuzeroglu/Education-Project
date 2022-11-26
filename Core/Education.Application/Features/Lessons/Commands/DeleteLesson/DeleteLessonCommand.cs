using Education.Application.Features.Lessons.DTOs;
using MediatR;

namespace Education.Application.Features.Lessons.Commands.DeleteLesson
{
    public class DeleteLessonCommand : IRequest<DeleteLessonDto>
    {
        public int Id { get; set; }
    }
}
