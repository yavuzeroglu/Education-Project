using FluentValidation;

namespace Education.Application.Features.Courses.Commands.UpdateCourse
{
    public class UpdateCourseCommandValidator : AbstractValidator<UpdateCourseCommand>
    {
        public UpdateCourseCommandValidator() {
            RuleFor(c => c.Id).NotEmpty().NotNull();
            RuleFor(c => c.Id).GreaterThan(0);

            RuleFor(c => c.Name).NotEmpty().NotNull();
            RuleFor(c => c.Name).MinimumLength(3);
        }
    }
}
