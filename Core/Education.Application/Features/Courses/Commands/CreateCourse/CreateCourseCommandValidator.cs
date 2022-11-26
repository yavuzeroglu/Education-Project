using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Application.Features.Courses.Commands.CreateCourse
{
    public class CreateCourseCommandValidator : AbstractValidator<CreateCourseCommand>
    {
        public CreateCourseCommandValidator() {
            RuleFor(c => c.Name).NotNull().NotEmpty();
            RuleFor(c => c.Name).MinimumLength(3);

        }
    }
}
