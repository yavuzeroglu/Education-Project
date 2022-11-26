using AutoMapper;
using Education.Application.Features.Subjects.DTOs;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Education.Application.Features.Subjects.Queries.GetByIdSubject
{
    public class GetByIdSubjectQueryHandler : IRequestHandler<GetByIdSubjectQuery, GetByIdSubjectDto>
    {
        private readonly ISubjectRepository _subjectRepository;
        private readonly IMapper _mapper;

        public GetByIdSubjectQueryHandler(ISubjectRepository subjectRepository, IMapper mapper)
        {
            _subjectRepository = subjectRepository;
            _mapper = mapper;
        }

        public async Task<GetByIdSubjectDto> Handle(GetByIdSubjectQuery request, CancellationToken cancellationToken)
        {
            Subject? subject =  await _subjectRepository.GetAsync(
                s => s.Id == request.Id, include: s => s.Include(s => s.Lesson)
                );
            GetByIdSubjectDto getByIdSubjectDto = _mapper.Map<GetByIdSubjectDto>(subject);

            return getByIdSubjectDto;
        }
    }
}
