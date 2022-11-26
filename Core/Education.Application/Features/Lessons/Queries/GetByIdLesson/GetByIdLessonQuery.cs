using Education.Application.Features.Lessons.DTOs;
using MediatR;

namespace Education.Application.Features.Lessons.Queries.GetByIdLesson
{
    public class GetByIdLessonQuery : IRequest<GetByIdLessonDto>
    {
        public int Id { get; set; }
    }
}
