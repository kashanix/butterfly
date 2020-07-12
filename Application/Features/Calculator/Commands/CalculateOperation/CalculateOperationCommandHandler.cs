using Application.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Calculator.Commands.CalculateOperation
{
    public class CalculateOperationCommandHandler : IRequestHandler<CalculateOperationCommand, decimal>
    {
        public Task<decimal> Handle(CalculateOperationCommand request, CancellationToken cancellationToken)
        {
            //CalculatFactory works as Transient
            return Task.FromResult(CalculatFactory.Create(request).Calculate());
        }
    }
}