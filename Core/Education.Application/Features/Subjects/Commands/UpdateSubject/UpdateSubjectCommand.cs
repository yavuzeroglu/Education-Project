using Education.Application.Features.Subjects.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Application.Features.Subjects.Commands.UpdateSubject
{
    public class UpdateSubjectCommand : IRequest<UpdateSubjectDto>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LessonId { get; set; }

    }
}
