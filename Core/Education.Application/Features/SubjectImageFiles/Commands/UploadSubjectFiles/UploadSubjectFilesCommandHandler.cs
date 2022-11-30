using Education.Application.Abstractions.Storage;
using Education.Application.Features.SubjectImageFiles.DTOs;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;

namespace Education.Application.Features.SubjectImageFiles.Commands.UploadSubjectFiles
{
    public class UploadSubjectFilesCommandHandler : IRequestHandler<UploadSubjectFilesCommand, UploadSubjectImageFileDto>
    {
        private readonly ISubjectImageFileRepository _subjectImageFileRepository;
        private readonly ISubjectRepository _subjectRepository;
        private readonly IStorageService _storageService;

        public UploadSubjectFilesCommandHandler(ISubjectImageFileRepository subjectImageFileRepository, ISubjectRepository subjectRepository, IStorageService storageService)
        {
            _subjectImageFileRepository = subjectImageFileRepository;
            _subjectRepository = subjectRepository;
            _storageService = storageService;
        }

        public async Task<UploadSubjectImageFileDto> Handle(UploadSubjectFilesCommand request, CancellationToken cancellationToken)
        {
            List<(string fileName, string pathOrContainerName)> result = await _storageService.UploadAsync("subject-images", request.Files);

            Subject? subject = await _subjectRepository.GetAsync(s => s.Id == request.Id);

            await _subjectImageFileRepository.AddRangeAsync(result.Select(s => new SubjectImageFile
            {
                FileName = s.fileName,
                Path = s.pathOrContainerName,
                Subjects = new List<Subject>() { subject }

            }).ToList());


            return new();
        }
    }
}
