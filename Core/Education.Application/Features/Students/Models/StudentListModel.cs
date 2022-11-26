using Core.Persistance.Paging;
using Education.Application.Features.Students.DTOs;

namespace Education.Application.Features.Students.Models
{
    public class StudentListModel : BasePageableModel
    {
        public IList<GetListStudentDto> Items { get; set; }
    }
}
