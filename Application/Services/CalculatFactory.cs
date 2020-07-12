using Application.Features.Calculator;
using Application.Features.Calculator.Commands.CalculateOperation;
using Application.SeedWork;
using Application.SeedWork.Exceptions;

namespace Application.Services
{
    public class CalculatFactory
    {
        public static BaseCalculator Create(CalculateOperationCommand cmd)
        {
            var input = new InputVariable(cmd.NumberA, cmd.NumberB);

            switch (cmd.Operation)
            {
                case OperationEnum.Add:
                    return new AddCalculator(input);

                case OperationEnum.Minus:
                    return new MinusCalculator(input);

                case OperationEnum.Multiply:
                    return new MultiplyCalculator(input);

                case OperationEnum.Divide:
                    return new DivideCalculator(input);

                default:
                    throw new BusinessException("Invalid Operation");
            }
        }
    }
}
