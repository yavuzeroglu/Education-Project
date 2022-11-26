using Core.Application.Requests;
using Education.Application.Features.Questions.Commands.CreateQuestion;
using Education.Application.Features.Questions.Commands.DeleteQuestion;
using Education.Application.Features.Questions.Commands.UpdateQuestion;
using Education.Application.Features.Questions.DTOs;
using Education.Application.Features.Questions.Queries.GetByIdQuestion;
using Education.Application.Features.Questions.Queries.GetListQuestion;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Education.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestionsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public QuestionsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListQuestionQuery getListQuestionQuery = new() { PageRequest = pageRequest };
            var response = await _mediator.Send(getListQuestionQuery);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdQuestionQuery getByIdQuestionQuery )
        {
            GetByIdQuestionDto response = await _mediator.Send(getByIdQuestionQuery);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateQuestionCommand createQuestionCommand)
        {
            var response = await _mediator.Send(createQuestionCommand);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteQuestionCommand deleteQuestionCommand)
        {
            var response = await _mediator.Send(deleteQuestionCommand);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateQuestionCommand updateQuestionCommand)
        {
            var response = await _mediator.Send(updateQuestionCommand);
            return Ok();
        }
    }
}
