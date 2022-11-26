using Core.Application.Requests;
using Education.Application.Features.Exams.Models;
using MediatR;

namespace Education.Application.Features.Exams.Queries.GetListExam
{
    public class GetListExamQuery : IRequest<ExamListModel>
    {
        public PageRequest PageRequest { get; set; }
    }
}
