using Core.Persistance.Paging;
using Education.Application.Features.Exams.DTOs;

namespace Education.Application.Features.Exams.Models
{
    internal class ExamListModel : BasePageableModel
    {
        public IList<GetListExamDto> Items { get; set; }
    }
}
