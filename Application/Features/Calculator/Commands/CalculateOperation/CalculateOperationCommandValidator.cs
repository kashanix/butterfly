using FluentValidation;

namespace Application.Features.Calculator.Commands.CalculateOperation
{
    public class CalculateOperationCommandValidator : AbstractValidator<CalculateOperationCommand>
    {
        public CalculateOperationCommandValidator()
        {
            RuleFor(v => v.NumberA)
                .NotNull();

            RuleFor(v => v.NumberB)
                .NotNull();

            RuleFor(v => v.NumberB)
                .GreaterThan(0)
                .When((e) => e.Operation == OperationEnum.Divide)
                .WithMessage("Devision by Zero");
        }
    }
}
