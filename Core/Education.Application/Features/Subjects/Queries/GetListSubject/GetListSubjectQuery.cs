
using Core.Application.Requests;
using Education.Application.Features.Subjects.Models;
using MediatR;

namespace Education.Application.Features.Subjects.Queries.GetListSubject
{
    public class GetListSubjectQuery : IRequest<SubjectListModel>
    {
        public PageRequest PageRequest { get; set; }
    }
}
