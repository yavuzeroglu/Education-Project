using Education.Application.Features.Exams.DTOs;
using MediatR;

namespace Education.Application.Features.Exams.Commands.UpdateExam
{
    public class UpdateExamCommand : IRequest<UpdateExamDto>
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }

    }
}
