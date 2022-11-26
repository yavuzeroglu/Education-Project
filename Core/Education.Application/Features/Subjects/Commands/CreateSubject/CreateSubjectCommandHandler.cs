using AutoMapper;
using Education.Application.Features.Subjects.DTOs;
using Education.Application.Features.Subjects.Rules;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;

namespace Education.Application.Features.Subjects.Commands.CreateSubject
{
    public class CreateSubjectCommandHandler : IRequestHandler<CreateSubjectCommand, CreateSubjectDto>
    {
        private readonly ISubjectRepository _subjectRepository;
        private readonly IMapper _mapper;
        private readonly SubjectBusinessRules _subjectBusinessRules;
        public CreateSubjectCommandHandler(ISubjectRepository subjectRepository, IMapper mapper, SubjectBusinessRules subjectBusinessRules)
        {
            _subjectRepository = subjectRepository;
            _mapper = mapper;
            _subjectBusinessRules = subjectBusinessRules;
        }

        public async Task<CreateSubjectDto> Handle(CreateSubjectCommand request, CancellationToken cancellationToken)
        {
            Subject mappedSubject = _mapper.Map<Subject>(request);
            Subject createdSubject = await _subjectRepository.AddAsync(mappedSubject);
            CreateSubjectDto createSubjectDto = _mapper.Map<CreateSubjectDto>(createdSubject);
            return createSubjectDto;
        }
    }
}
