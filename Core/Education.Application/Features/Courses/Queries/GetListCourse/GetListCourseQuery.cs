using Core.Application.Requests;
using Education.Application.Features.Courses.Models;
using MediatR;

namespace Education.Application.Features.Courses.Queries.GetListCourse
{
    public class GetListCourseQuery : IRequest<CourseListModel>
    {
        public PageRequest PageRequest { get; set; }

    }
}
