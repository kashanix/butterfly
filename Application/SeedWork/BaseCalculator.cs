namespace Application.SeedWork
{
    public abstract class BaseCalculator
    {
        protected InputVariable input;
        public BaseCalculator(InputVariable _input)
        {
            input = _input;
        }
        public abstract decimal Calculate();
    }
}
