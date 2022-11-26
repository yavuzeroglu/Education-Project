using FluentValidation;

namespace Education.Application.Features.Courses.Commands.DeleteCourse
{
    public class DeleteCourseCommandValidator : AbstractValidator<DeleteCourseCommand>
    {
        public DeleteCourseCommandValidator() {
            RuleFor(c => c.Id).NotNull().NotEmpty();
            RuleFor(c => c.Id).GreaterThan(0);

        }   
    }
}
