using Education.Application.Features.Exams.DTOs;
using Education.Domain.Entities;
using MediatR;

namespace Education.Application.Features.Exams.Queries.GetByIdExam
{
    public class GetByIdExamQuery : IRequest<GetByIdExamDto>
    {
        public int Id { get; set; }
        
    }
}
