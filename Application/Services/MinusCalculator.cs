using Application.SeedWork;

namespace Application.Services
{
    public class MinusCalculator : BaseCalculator
    {
        public MinusCalculator(InputVariable _input) : base(_input)
        {
        }

        public override decimal Calculate()
        {
            return input.InputA - input.InputB;
        }
    }
}
