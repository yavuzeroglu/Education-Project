using AutoMapper;
using Education.Application.Features.Lessons.DTOs;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;

namespace Education.Application.Features.Lessons.Commands.DeleteLesson
{
    public class DeleteLessonCommandHandler : IRequestHandler<DeleteLessonCommand, DeleteLessonDto>
    {
        private readonly IMapper _mapper;
        private readonly ILessonRepository _lessonRepository;

        public DeleteLessonCommandHandler(IMapper mapper, ILessonRepository lessonRepository)
        {
            _mapper = mapper;
            _lessonRepository = lessonRepository;
        }

        public async Task<DeleteLessonDto> Handle(DeleteLessonCommand request, CancellationToken cancellationToken)
        {
            Lesson? lessonToDelete = await _lessonRepository.GetAsync(l => l.Id == request.Id);

            Lesson deletedLesson = await _lessonRepository.DeleteAsync(lessonToDelete);
            return _mapper.Map<DeleteLessonDto>(deletedLesson);
        }
    }
}
