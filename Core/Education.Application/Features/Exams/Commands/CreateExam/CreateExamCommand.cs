using Education.Application.Features.Exams.DTOs;
using MediatR;

namespace Education.Application.Features.Exams.Commands.CreateExam
{
    public class CreateExamCommand : IRequest<CreateExamDto>
    {
        public int SubjectId { get; set; }
    }
}
