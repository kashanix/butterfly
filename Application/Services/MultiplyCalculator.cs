using Application.SeedWork;

namespace Application.Services
{
    public class MultiplyCalculator : BaseCalculator
    {
        public MultiplyCalculator(InputVariable _input) : base(_input)
        {
        }

        public override decimal Calculate()
        {
            return input.InputA * input.InputB;
        }
    }

}
