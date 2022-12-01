using Education.Application.Features.SubjectImageFiles.DTOs;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Education.Application.Features.SubjectImageFiles.Commands.RemoveSubjectImageFile
{
    public class RemoveSubjectImageFileCommandHandler : IRequestHandler<RemoveSubjectImageFileCommand, RemoveSubjectImageFileDto>
    {
        private readonly ISubjectRepository _subjectRepository;
        private readonly ISubjectImageFileRepository _subjectImageFileRepository;

        public RemoveSubjectImageFileCommandHandler(ISubjectRepository subjectRepository, ISubjectImageFileRepository subjectImageFileRepository)
        {
            _subjectRepository = subjectRepository;
            _subjectImageFileRepository = subjectImageFileRepository;
        }

        public async Task<RemoveSubjectImageFileDto> Handle(RemoveSubjectImageFileCommand request, CancellationToken cancellationToken)
        {
            Subject? subject = await _subjectRepository
                .GetAsync(s => s.Id == request.Id, 
                include: s => s.Include(s => s.SubjectImageFiles));

            SubjectImageFile? subjectImageFile = subject?.SubjectImageFiles.FirstOrDefault(s => s.Id == request.ImageId);

            if (subjectImageFile != null)
                _subjectImageFileRepository.DeleteAsync(subjectImageFile);

            return new();

        }
    }
}
