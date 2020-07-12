using Application.SeedWork;

namespace Application.Services
{
    public class AddCalculator : BaseCalculator
    {
        public AddCalculator(InputVariable _input) : base(_input)
        {
        }

        public  override decimal Calculate()
        {
            return input.InputA + input.InputB;
        }
    }
}
