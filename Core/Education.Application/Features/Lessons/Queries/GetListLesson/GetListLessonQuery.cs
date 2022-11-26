using Core.Application.Requests;
using Education.Application.Features.Lessons.Models;
using MediatR;

namespace Education.Application.Features.Lessons.Queries.GetListCourse
{
    public class GetListLessonQuery : IRequest<LessonListModel>
    {
        public PageRequest PageRequest { get; set; }
    }
}
