using Core.Application.Requests;
using Education.Application.Features.Courses.Commands.CreateCourse;
using Education.Application.Features.Courses.Commands.DeleteCourse;
using Education.Application.Features.Courses.Commands.UpdateCourse;
using Education.Application.Features.Courses.DTOs;
using Education.Application.Features.Courses.Queries.GetByIdCourse;
using Education.Application.Features.Courses.Queries.GetListCourse;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Education.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = "Admin")]
    public class CoursesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CoursesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListCourseQuery getListCourseQuery = new() { PageRequest = pageRequest };
            var response = await _mediator.Send(getListCourseQuery);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdCourseQuery getByIdCourseQuery)
        {
            GetByIdCourseDto response = await _mediator.Send(getByIdCourseQuery);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCourseCommand createCourseCommand)
        {
            CreateCourseDto response = await _mediator.Send(createCourseCommand);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateCourseCommand updateCourseCommand)
        {
            var response = await _mediator.Send(updateCourseCommand);
            return Ok();
        }
        
        [HttpDelete("Delete/{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteCourseCommand deleteCourseCommand)
        {
            var response = await _mediator.Send(deleteCourseCommand);
            return Ok();
        }
    }
}
