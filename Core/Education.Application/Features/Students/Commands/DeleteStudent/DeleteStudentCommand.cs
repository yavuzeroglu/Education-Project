using Education.Application.Features.Students.DTOs;
using MediatR;

namespace Education.Application.Features.Students.Commands.DeleteStudent
{
    public class DeleteStudentCommand : IRequest<DeleteStudentDto>
    {
        public int Id { get; set; }
    }
}
