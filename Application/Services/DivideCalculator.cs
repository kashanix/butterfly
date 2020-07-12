using Application.SeedWork;
using Application.SeedWork.Exceptions;

namespace Application.Services
{
    public class DivideCalculator : BaseCalculator
    {
        public DivideCalculator(InputVariable _input) : base(_input)
        {
        }

        private bool Validate()
        {
            if (input.InputB == 0)
            {
                throw new BusinessException("For operation / second input should not be Zero ");
            }

            return true;
        }

        public override decimal Calculate()
        {
            Validate();

            return input.InputA / input.InputB;
        }
    }
}
