using Education.Application.Features.SubjectImageFiles.DTOs;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Education.Application.Features.SubjectImageFiles.Commands.UploadSubjectFiles
{
    public class UploadSubjectFilesCommand : IRequest<UploadSubjectImageFileDto>
    {
        public int Id { get; set; }
        public IFormFileCollection Files { get; set; }
    }
}
