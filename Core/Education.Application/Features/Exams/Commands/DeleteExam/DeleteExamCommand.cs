using Education.Application.Features.Exams.DTOs;
using MediatR;

namespace Education.Application.Features.Exams.Commands.DeleteExam
{
    public class DeleteExamCommand : IRequest<DeleteExamDto>
    {
        public int Id { get; set; }

    }
}
