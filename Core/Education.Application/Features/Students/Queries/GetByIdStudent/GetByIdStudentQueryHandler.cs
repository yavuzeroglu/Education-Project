using AutoMapper;
using Education.Application.Features.Students.DTOs;
using Education.Application.Features.Students.Rules;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;

namespace Education.Application.Features.Students.Queries.GetByIdStudent
{
    public partial class GetByIdStudentQuery
    {
        public class GetByIdStudentQueryHandler : IRequestHandler<GetByIdStudentQuery, GetByIdStudentDto>
        {
            private readonly IStudentRepository _studentRepository;
            private readonly IMapper _mapper;
            private readonly StudentBusinessRules _studentBusinessRules;
            public GetByIdStudentQueryHandler(IStudentRepository studentRepository, IMapper mapper, StudentBusinessRules studentBusinessRules)
            {
                _studentRepository = studentRepository;
                _mapper = mapper;
                _studentBusinessRules = studentBusinessRules;
            }

            public async Task<GetByIdStudentDto> Handle(GetByIdStudentQuery request, CancellationToken cancellationToken)
            {
                Student? student = await _studentRepository.GetAsync(s => s.Id == request.Id);
                _studentBusinessRules.StudentShouldExistWhenRequsted(student);

                GetByIdStudentDto getByIdStudentDto = _mapper.Map<GetByIdStudentDto>(student);
                return getByIdStudentDto;

            }
        }
    }
}
