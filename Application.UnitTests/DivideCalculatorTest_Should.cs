using Application.SeedWork;
using Application.SeedWork.Exceptions;
using Application.Services;
using Xunit;

namespace Application.UnitTests
{
    public class DivideCalculatorTest_Should
    {
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(2, 2, 1)]
        public void Add_Inputs(decimal inputA, decimal inputB, decimal equal)
        {
            var sut = new DivideCalculator(new InputVariable(inputA, inputB)).Calculate();

            Assert.Equal(equal, sut);
        }

        [Theory]
        [InlineData(1, 0)]
        public void ThrowException_ForDividebyZero(decimal inputA, decimal inputB)
        {

            Assert.Throws<BusinessException>(() =>
            {
                new DivideCalculator(new InputVariable(inputA, inputB)).Calculate();
            });
        }
    }
}
