using Core.Persistance.Paging;
using Education.Application.Features.Subjects.DTOs;

namespace Education.Application.Features.Subjects.Models
{
    public class SubjectListModel : BasePageableModel
    {
        public IList<GetListSubjectDto> Items { get; set; }
    }
}
