using Education.Application.Features.Courses.DTOs;
using MediatR;

namespace Education.Application.Features.Courses.Commands.DeleteCourse
{
    public class DeleteCourseCommand : IRequest<DeleteCourseDto>
    {
        public int Id { get; set; }

    }
}
