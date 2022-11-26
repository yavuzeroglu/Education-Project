using FluentValidation;

namespace Education.Application.Features.Students.Commands.CreateStudent
{
    public class CreateStudentCommandValidator : AbstractValidator<CreateStudentCommand>
    {
        public CreateStudentCommandValidator()
        {
            RuleFor(s => s.Name).NotEmpty().NotNull();
            RuleFor(s => s.Name).MinimumLength(2);

            RuleFor(s => s.Surname).NotEmpty().NotNull();
            RuleFor(s => s.Surname).MinimumLength(2);

            RuleFor(s => s.Password).NotEmpty().NotNull();
            RuleFor(s => s.Password).MinimumLength(3);

            RuleFor(s => s.Phone).NotNull().NotNull();
            RuleFor(s => s.Phone).MinimumLength(11).MaximumLength(11);


            RuleFor(s => s.Email).NotEmpty().NotNull();
            RuleFor(s => s.Email).EmailAddress();
            RuleFor(s => s.Email).MinimumLength(6);
        }
    }
}
