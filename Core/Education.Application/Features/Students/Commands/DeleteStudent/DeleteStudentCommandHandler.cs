using AutoMapper;
using Education.Application.Features.Students.DTOs;
using Education.Application.Features.Students.Rules;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;

namespace Education.Application.Features.Students.Commands.DeleteStudent
{
    public class DeleteStudentCommandHandler : IRequestHandler<DeleteStudentCommand, DeleteStudentDto>
    {
        private readonly IMapper _mapper;
        private readonly IStudentRepository _studentRepository;
        private readonly StudentBusinessRules _studentBusinessRules;

        public DeleteStudentCommandHandler(IMapper mapper, IStudentRepository studentRepository, StudentBusinessRules studentBusinessRules)
        {
            _mapper = mapper;
            _studentRepository = studentRepository;
            _studentBusinessRules = studentBusinessRules;
        }

        public async Task<DeleteStudentDto> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            Student? student = await _studentRepository.GetAsync(s => s.Id == request.Id);
            _studentBusinessRules.StudentShouldExistWhenRequsted(student);

            Student? deletedStudent = await _studentRepository.DeleteAsync(student);
            DeleteStudentDto deleteStudentDto = _mapper.Map<DeleteStudentDto>(deletedStudent);
            
            return deleteStudentDto;
        }
    }
}
