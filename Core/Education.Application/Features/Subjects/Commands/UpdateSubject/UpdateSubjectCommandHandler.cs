using AutoMapper;
using Education.Application.Features.Subjects.DTOs;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;

namespace Education.Application.Features.Subjects.Commands.UpdateSubject
{
    public class UpdateSubjectCommandHandler : IRequestHandler<UpdateSubjectCommand, UpdateSubjectDto>
    {
        private readonly ISubjectRepository _subjectRepository;
        private readonly IMapper _mapper;

        public UpdateSubjectCommandHandler(ISubjectRepository subjectRepository, IMapper mapper)
        {
            _subjectRepository = subjectRepository;
            _mapper = mapper;
        }

        public async Task<UpdateSubjectDto> Handle(UpdateSubjectCommand request, CancellationToken cancellationToken)
        {
            Subject subject = await _subjectRepository.GetAsync(s => s.Id == request.Id);

            subject = _mapper.Map(request, subject);
            subject = await _subjectRepository.UpdateAsync(subject);
            UpdateSubjectDto updateSubjectDto = _mapper.Map<UpdateSubjectDto>(subject);
            return updateSubjectDto;

        }
    }
}
