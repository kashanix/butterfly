using Application.Features.Calculator;
using Application.Features.Calculator.Commands.CalculateOperation;
using Application.IntegrationTests.Fixtures;
using Application.SeedWork;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using Xunit;

namespace Application.IntegrationTests.Feature.Users
{
    [Collection("Application")]
    public class CalculateOperation_Should
    {
        private readonly TestHostFixture _testHostFixture;

        public CalculateOperation_Should(TestHostFixture fixture) => _testHostFixture = fixture;

        [Theory]
        [InlineData(1, 1, OperationEnum.Add, 2)]
        [InlineData(1, 1, OperationEnum.Divide, 1)]
        public async void CalculateOperation(decimal inputA, decimal inputB, OperationEnum operation, decimal answer)
        {
            var data = new CalculateOperationCommand() { NumberA = inputA, NumberB = inputB, Operation = operation };

            using (var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json"))
            {
                var response = await _testHostFixture.Client.PostAsync("/api/CalculateOperation/Calculate", content);
                string returnValue = response.Content.ReadAsStringAsync().Result;

                Assert.Equal(HttpStatusCode.OK, response.StatusCode);
                Assert.Equal(Convert.ToDecimal(returnValue), answer);
            }
        }
    }
}
