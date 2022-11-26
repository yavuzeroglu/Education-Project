using AutoMapper;
using Education.Application.Features.Lessons.DTOs;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;

namespace Education.Application.Features.Lessons.Commands.UpdateLesson
{
    public class UpdateLessonCommandHandler : IRequestHandler<UpdateLessonCommand, UpdateLessonDto>
    {
        private readonly ILessonRepository _lessonRepository;
        private readonly IMapper _mapper;

        public UpdateLessonCommandHandler(ILessonRepository lessonRepository, IMapper mapper)
        {
            _lessonRepository = lessonRepository;
            _mapper = mapper;
        }

        public async Task<UpdateLessonDto> Handle(UpdateLessonCommand request, CancellationToken cancellationToken)
        {
            Lesson lesson = await _lessonRepository.GetAsync(p => p.Id == request.Id);
            lesson = await _lessonRepository.UpdateAsync(_mapper.Map(request, lesson));
            UpdateLessonDto updateLessonDto = _mapper.Map<UpdateLessonDto>(lesson);

            return updateLessonDto;


        }
    }
}
