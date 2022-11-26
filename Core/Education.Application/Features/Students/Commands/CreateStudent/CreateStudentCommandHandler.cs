using AutoMapper;
using Education.Application.Features.Students.DTOs;
using Education.Application.Features.Students.Rules;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;

namespace Education.Application.Features.Students.Commands.CreateStudent
{
    public partial class CreateStudentCommand
    {
        public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, CreateStudentDto>
        {
            private readonly IStudentRepository _studentRepository;
            private readonly IMapper _mapper;
            private readonly StudentBusinessRules _studentBusinessRules;

            public CreateStudentCommandHandler(IStudentRepository studentRepository, IMapper mapper, StudentBusinessRules studentBusinessRules)
            {
                _studentRepository = studentRepository;
                _mapper = mapper;
                _studentBusinessRules = studentBusinessRules;
            }

            public async Task<CreateStudentDto> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
            {
                 await _studentBusinessRules.StudentEmailCanNotDuplicatedWhenInserted(request.Email);

                Student mappedStudent = _mapper.Map<Student>(request);
                Student createdStudent = await _studentRepository.AddAsync(mappedStudent);
                CreateStudentDto createStudentDto = _mapper.Map<CreateStudentDto>(createdStudent);

                return createStudentDto;
            }
        }
    }
}
