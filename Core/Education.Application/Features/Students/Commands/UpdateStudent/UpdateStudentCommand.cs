using Education.Application.Features.Students.DTOs;
using MediatR;

namespace Education.Application.Features.Students.Commands.UpdateStudent
{
    public partial class UpdateStudentCommand : IRequest<UpdateStudentDto>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
