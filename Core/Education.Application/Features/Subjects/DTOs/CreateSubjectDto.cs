using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Application.Features.Subjects.DTOs
{
    public class CreateSubjectDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LessonId { get; set; }

    }
}
