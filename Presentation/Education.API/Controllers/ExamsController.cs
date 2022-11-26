using Core.Application.Requests;
using Education.Application.Features.Exams.Commands.CreateExam;
using Education.Application.Features.Exams.Commands.DeleteExam;
using Education.Application.Features.Exams.Commands.UpdateExam;
using Education.Application.Features.Exams.Queries.GetByIdExam;
using Education.Application.Features.Exams.Queries.GetListExam;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Education.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExamsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ExamsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListExamQuery getListExamQuery = new() { PageRequest = pageRequest };
            var response = await _mediator.Send(getListExamQuery);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdExamQuery getByIdExamQuery)
        {
            var response = await _mediator.Send(getByIdExamQuery);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateExamCommand createExamCommand)
        {
            var response = await _mediator.Send(createExamCommand);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateExamCommand updateExamCommand)
        {
            var response = await _mediator.Send(updateExamCommand);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteExamCommand deleteExamCommand)
        {
            var response = await _mediator.Send(deleteExamCommand);
            return Ok();
        }

    }
}
