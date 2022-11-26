using Education.Application.Features.Subjects.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Application.Features.Subjects.Commands.DeleteSubject
{
    public class DeleteSubjectCommand : IRequest<DeleteSubjectDto>
    {
        public int Id { get; set; }
    }
}
