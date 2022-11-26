using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Application.Features.Lessons.DTOs
{
    public class CreateLessonDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CourseId { get; set; }

    }
}
