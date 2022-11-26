using AutoMapper;
using Core.Persistance.Paging;
using Education.Application.Features.Students.Models;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;

namespace Education.Application.Features.Students.Queries.GetListStudent
{
    public partial class GetListStudentQuery
    {
        public class GetListStudentQueryHandler : IRequestHandler<GetListStudentQuery, StudentListModel>
        {
            private readonly IStudentRepository _studentRepository;
            private readonly IMapper _mapper;
            public GetListStudentQueryHandler(IStudentRepository studentRepository, IMapper mapper)
            {
                _studentRepository = studentRepository;
                _mapper = mapper;
            }

            public async Task<StudentListModel> Handle(GetListStudentQuery request, CancellationToken cancellationToken)
            {
                IPaginate<Student> students = await _studentRepository.GetListAsync(
                    index: request.PageRequest.Page,
                    size: request.PageRequest.PageSize
                    );
                StudentListModel studentListModel = _mapper.Map<StudentListModel>(students);

                return studentListModel;
            }
        }
    }
}
