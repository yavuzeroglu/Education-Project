using AutoMapper;
using Core.Application.Requests;
using Education.Application.Features.Students.Commands.CreateStudent;
using Education.Application.Features.Students.Commands.DeleteStudent;
using Education.Application.Features.Students.Commands.UpdateStudent;
using Education.Application.Features.Students.DTOs;
using Education.Application.Features.Students.Models;
using Education.Application.Features.Students.Queries.GetByIdStudent;
using Education.Application.Features.Students.Queries.GetListStudent;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Education.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListStudentQuery getListStudentQuery = new() { PageRequest = pageRequest };
            StudentListModel response = await _mediator.Send(getListStudentQuery);

            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdStudentQuery getByIdStudentQuery)
        {
            GetByIdStudentDto response = await _mediator.Send(getByIdStudentQuery);
            return Ok(response);
        }


        [HttpPost]
        public async Task<IActionResult> CreateStudent([FromBody] CreateStudentCommand createStudentCommand)
        {
            CreateStudentDto response = await _mediator.Send(createStudentCommand);
            return Created("", response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStudent([FromBody] UpdateStudentCommand updateStudentCommand)
        {
            UpdateStudentDto response = await _mediator.Send(updateStudentCommand);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteStudentCommand deleteStudentCommand)
        {
            DeleteStudentDto response = await _mediator.Send(deleteStudentCommand);
            return Ok();
        }
    }
}
