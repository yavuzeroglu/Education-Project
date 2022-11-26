using FluentValidation;

namespace Education.Application.Features.Students.Queries.GetByIdStudent
{
    public class GetByIdStudentQueryValidator : AbstractValidator<GetByIdStudentQuery>
    {
        public GetByIdStudentQueryValidator()
        {
            RuleFor(s => s.Id).NotEmpty().NotNull();
            RuleFor(s => s.Id).GreaterThan(0);
        }
    }
}
