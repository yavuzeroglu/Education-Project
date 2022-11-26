using Education.Application.Features.Courses.DTOs;
using MediatR;

namespace Education.Application.Features.Courses.Commands.UpdateCourse
{
    public class UpdateCourseCommand : IRequest<UpdateCourseDto>
    {
        public int Id { get; set; }
        public string Name { get; set; }
         
    }
}
