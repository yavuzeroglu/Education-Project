using AutoMapper;
using Education.Application.Features.Lessons.DTOs;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;

namespace Education.Application.Features.Lessons.Commands.CreateLesson
{
    public class CreateLessonCommandHandler : IRequestHandler<CreateLessonCommand, CreateLessonDto>
    {
        private readonly ILessonRepository _lessonRepository;
        private readonly IMapper _mapper;
        //private readonly LessonBusinessRules lessonBusinessRules;

        public CreateLessonCommandHandler(ILessonRepository lessonRepository, IMapper mapper)
        {
            _lessonRepository = lessonRepository;
            _mapper = mapper;
        }

        public async Task<CreateLessonDto> Handle(CreateLessonCommand request, CancellationToken cancellationToken)
        {
            Lesson lesson = _mapper.Map<Lesson>(request);
            var createdLesson = await _lessonRepository.AddAsync(lesson);
            var createLessonDto = _mapper.Map<CreateLessonDto>(createdLesson);

            return createLessonDto;

            
            
        }
    }
}
