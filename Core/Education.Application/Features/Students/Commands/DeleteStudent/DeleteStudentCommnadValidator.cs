using FluentValidation;

namespace Education.Application.Features.Students.Commands.DeleteStudent
{
    public class DeleteStudentCommnadValidator : AbstractValidator<DeleteStudentCommand>
    {
        public DeleteStudentCommnadValidator()
        {
            RuleFor(s => s.Id).NotNull().NotEmpty();
            RuleFor(s => s.Id).GreaterThan(0);
        }
    }
}
