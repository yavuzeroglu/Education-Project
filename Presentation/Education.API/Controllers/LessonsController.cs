using Core.Application.Requests;
using Education.Application.Features.Lessons.Commands.CreateLesson;
using Education.Application.Features.Lessons.Commands.DeleteLesson;
using Education.Application.Features.Lessons.Commands.UpdateLesson;
using Education.Application.Features.Lessons.Models;
using Education.Application.Features.Lessons.Queries.GetByIdLesson;
using Education.Application.Features.Lessons.Queries.GetListCourse;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Education.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LessonsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LessonsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] PageRequest pageRequest)
        {
            GetListLessonQuery getListLessonQuery = new() { PageRequest = pageRequest };
            LessonListModel response = await _mediator.Send(getListLessonQuery);

            return Ok(response);

        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdLessonQuery getByIdLessonQuery)
        {
            var response = await _mediator.Send(getByIdLessonQuery);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateLessonCommand createLessonCommand)
        {
            var response = _mediator.Send(createLessonCommand);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateLessonCommand updateLessonCommand)
        {
            var response = await _mediator.Send(updateLessonCommand);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteLessonCommand deleteLessonCommand)
        {
            var response = await _mediator.Send(deleteLessonCommand);
            return Ok();
        }
    }
}


