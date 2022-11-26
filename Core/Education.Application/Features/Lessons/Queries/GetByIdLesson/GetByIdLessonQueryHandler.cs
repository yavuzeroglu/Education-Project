using AutoMapper;
using Education.Application.Features.Lessons.DTOs;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Education.Application.Features.Lessons.Queries.GetByIdLesson
{
    public class GetByIdLessonQueryHandler : IRequestHandler<GetByIdLessonQuery, GetByIdLessonDto>
    {
        private readonly ILessonRepository _lessonRepository;
        private readonly IMapper _mapper;
        //private readonly LessonBusinessRules _lessonBusinessRules;

        public GetByIdLessonQueryHandler(ILessonRepository lessonRepository, IMapper mapper)
        {
            _lessonRepository = lessonRepository;
            _mapper = mapper;
        }

        public async Task<GetByIdLessonDto> Handle(GetByIdLessonQuery request, CancellationToken cancellationToken)
        {
            var lesson =  await _lessonRepository.GetAsync(l => l.Id == request.Id, include: a => a.Include(l => l.Course));
            Lesson mappedLesson = _mapper.Map<Lesson>(lesson);
            var lessonDto = _mapper.Map<GetByIdLessonDto>(mappedLesson);

            return lessonDto;
        }
    }
}
