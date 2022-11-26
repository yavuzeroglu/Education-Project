using AutoMapper;
using Education.Application.Features.Subjects.DTOs;
using Education.Application.Features.Subjects.Rules;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;

namespace Education.Application.Features.Subjects.Commands.DeleteSubject
{
    public class DeleteSubjectCommandHandler : IRequestHandler<DeleteSubjectCommand, DeleteSubjectDto>
    {
        private readonly ISubjectRepository _subjectRepository;
        private readonly IMapper _mapper;
        private readonly SubjectBusinessRules _subjectBusinessRules;
        public DeleteSubjectCommandHandler(ISubjectRepository subjectRepository, IMapper mapper, SubjectBusinessRules subjectBusinessRules)
        {
            _subjectRepository = subjectRepository;
            _mapper = mapper;
            _subjectBusinessRules = subjectBusinessRules;
        }

        public async Task<DeleteSubjectDto> Handle(DeleteSubjectCommand request, CancellationToken cancellationToken)
        {
            Subject subject = await _subjectRepository.GetAsync(c => c.Id == request.Id);

            subject = await _subjectRepository.DeleteAsync(subject);
            DeleteSubjectDto deleteSubjectDto = _mapper.Map<DeleteSubjectDto>(subject);
            return deleteSubjectDto;
        }
    }
}
