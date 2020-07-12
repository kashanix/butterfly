using Application.SeedWork;
using Application.Services;
using Xunit;

namespace Application.UnitTests
{
    public class AddCalculatorTest_Should
    {
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(12.1, 1, 13.1)]
        public void Add_Inputs(decimal inputA, decimal inputB, decimal equal)
        {
            var sut = new AddCalculator(new InputVariable(inputA, inputB)).Calculate();

            Assert.Equal(equal, sut);
        }
    }
}
