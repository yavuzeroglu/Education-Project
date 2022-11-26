using Education.Application.Features.Subjects.DTOs;
using MediatR;

namespace Education.Application.Features.Subjects.Commands.CreateSubject
{
    public class CreateSubjectCommand : IRequest<CreateSubjectDto>
    {
        public string Name { get; set; }
        public int LessonId { get; set; }
    }
}
