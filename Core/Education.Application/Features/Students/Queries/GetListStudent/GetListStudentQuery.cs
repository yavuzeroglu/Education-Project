using Core.Application.Requests;
using Education.Application.Features.Students.DTOs;
using Education.Application.Features.Students.Models;
using MediatR;

namespace Education.Application.Features.Students.Queries.GetListStudent
{
    public partial class GetListStudentQuery : IRequest<StudentListModel>
    {
        public PageRequest PageRequest { get; set; }
    }
}
