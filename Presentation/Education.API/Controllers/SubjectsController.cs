using Core.Application.Requests;
using Education.Application.Features.SubjectImageFiles.Commands.RemoveSubjectImageFile;
using Education.Application.Features.SubjectImageFiles.Commands.UploadSubjectFiles;
using Education.Application.Features.SubjectImageFiles.DTOs;
using Education.Application.Features.Subjects.Commands.CreateSubject;
using Education.Application.Features.Subjects.Commands.DeleteSubject;
using Education.Application.Features.Subjects.Commands.UpdateSubject;
using Education.Application.Features.Subjects.Queries.GetByIdSubject;
using Education.Application.Features.Subjects.Queries.GetListSubject;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Education.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IWebHostEnvironment _webHostEnvironment;
        


        public SubjectsController(IMediator mediator, IWebHostEnvironment webHostEnvironment)
        {
            _mediator = mediator;
            _webHostEnvironment = webHostEnvironment;
            
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListSubjectQuery getListSubjectQuery = new() { PageRequest = pageRequest };
            var response = await _mediator.Send(getListSubjectQuery);

            return Ok(response);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdSubjectQuery getByIdSubjectQuery)
        {
            var response = await _mediator.Send(getByIdSubjectQuery);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateSubjectCommand createSubjectCommand)
        {
            var response = await _mediator.Send(createSubjectCommand);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteSubjectCommand deleteSubjectCommand)
        {
            var response = await _mediator.Send(deleteSubjectCommand);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateSubjectCommand updateSubjectCommand)
        {
            var response = await _mediator.Send(updateSubjectCommand);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Upload([FromQuery] UploadSubjectFilesCommand uploadSubjectFilesCommand)
        {
            uploadSubjectFilesCommand.Files = Request.Form.Files;
            UploadSubjectImageFileDto uploadSubjectImageFileDto = await _mediator.Send(uploadSubjectFilesCommand);
            return Ok();
        }

        [HttpDelete("[action]/{Id}")]
        public async Task<IActionResult> DeleteSubjectImage([FromRoute] RemoveSubjectImageFileCommand removeSubjectImageFileCommand, [FromQuery] int imageId)
        {
            removeSubjectImageFileCommand.ImageId = imageId;
            RemoveSubjectImageFileDto response = await _mediator.Send(removeSubjectImageFileCommand);

            return Ok();
        }

    }
}
