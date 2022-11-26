using Education.Application.Features.Students.DTOs;
using MediatR;

namespace Education.Application.Features.Students.Commands.CreateStudent
{
    public partial class CreateStudentCommand : IRequest<CreateStudentDto>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
    }
}
