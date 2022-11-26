using Education.Application.Features.Students.DTOs;
using MediatR;

namespace Education.Application.Features.Students.Queries.GetByIdStudent
{
    public partial class GetByIdStudentQuery : IRequest<GetByIdStudentDto>
    {
        public int Id { get; set; }
    }
}
