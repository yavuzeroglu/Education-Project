using Education.Application.Features.Courses.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Application.Features.Courses.Commands.CreateCourse
{
    public class CreateCourseCommand : IRequest<CreateCourseDto>
    {
        public string Name { get; set; }
        //public int? ExamId { get; set; }
    }
}
