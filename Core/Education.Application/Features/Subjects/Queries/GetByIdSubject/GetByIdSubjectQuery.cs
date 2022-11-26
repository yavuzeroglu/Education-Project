using Education.Application.Features.Subjects.DTOs;
using MediatR;

namespace Education.Application.Features.Subjects.Queries.GetByIdSubject
{
    public class GetByIdSubjectQuery : IRequest<GetByIdSubjectDto>
    {
        public int Id { get; set; }
        
    }
}
