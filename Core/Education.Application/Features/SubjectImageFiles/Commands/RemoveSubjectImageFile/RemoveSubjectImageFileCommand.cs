using Education.Application.Features.SubjectImageFiles.DTOs;
using MediatR;

namespace Education.Application.Features.SubjectImageFiles.Commands.RemoveSubjectImageFile
{
    public class RemoveSubjectImageFileCommand : IRequest<RemoveSubjectImageFileDto>
    {
        public int Id { get; set; }
        public int ImageId { get; set; }

    }
}
