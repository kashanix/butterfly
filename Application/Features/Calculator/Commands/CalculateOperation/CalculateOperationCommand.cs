using MediatR;

namespace Application.Features.Calculator.Commands.CalculateOperation
{
    public class CalculateOperationCommand : IRequest<decimal>
    {
        public decimal NumberA { get; set; }
        public decimal NumberB { get; set; }
        public OperationEnum Operation { get; set; }
    }
}
