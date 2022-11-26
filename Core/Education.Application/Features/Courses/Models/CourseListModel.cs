using Core.Persistance.Paging;
using Education.Application.Features.Courses.DTOs;

namespace Education.Application.Features.Courses.Models
{
    public class CourseListModel : BasePageableModel
    {
        public IList<ListCourseDto> Items { get; set; }
    }
}
