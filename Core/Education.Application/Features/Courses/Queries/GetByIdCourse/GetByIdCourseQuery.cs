using Education.Application.Features.Courses.DTOs;
using MediatR;

namespace Education.Application.Features.Courses.Queries.GetByIdCourse
{
    public class GetByIdCourseQuery : IRequest<GetByIdCourseDto>
    {
        public int Id { get; set; }
    }
}
