using Core.Persistance.Paging;
using Education.Application.Features.Lessons.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Application.Features.Lessons.Models
{
    public class LessonListModel : BasePageableModel
    {
        public IList<GetListLessonDto> Items { get; set; }
    }
}
