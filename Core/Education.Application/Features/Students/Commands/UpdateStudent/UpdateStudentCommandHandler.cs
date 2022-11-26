using AutoMapper;
using Education.Application.Features.Students.DTOs;
using Education.Application.Features.Students.Rules;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;

namespace Education.Application.Features.Students.Commands.UpdateStudent
{
    public partial class UpdateStudentCommand
    {
        public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommand, UpdateStudentDto>
        {
            private readonly IStudentRepository _studentRepository;
            private readonly IMapper _mapper;
            private readonly StudentBusinessRules _studentBusinessRules;

            public UpdateStudentCommandHandler(IStudentRepository studentRepository, IMapper mapper, StudentBusinessRules studentBusinessRules)
            {
                _studentRepository = studentRepository;
                _mapper = mapper;
                _studentBusinessRules = studentBusinessRules;
            }

            public async Task<UpdateStudentDto> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
            {
                await _studentBusinessRules.StudentEmailCanNotDuplicatedWhenInserted(request.Email);
                Student studentToUpdate = await _studentRepository.GetAsync(s => s.Id == request.Id);


                Student mappedStudent = _mapper.Map(request, studentToUpdate);

                Student updatedStudent = _studentRepository.Update(mappedStudent);
                UpdateStudentDto updateStudentDto = _mapper.Map<UpdateStudentDto>(updatedStudent);

                return updateStudentDto;


            }
        }
    }
}
