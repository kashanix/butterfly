using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net.Http;
using Web.Api;

namespace Application.IntegrationTests.Fixtures
{
    public class TestHostFixture : CustomWebApplicationFactory<Startup>, IDisposable
    {
        public readonly HttpClient Client;
        public readonly CustomWebApplicationFactory<Startup> Factory;

        public TestHostFixture()
        {
            Factory = new CustomWebApplicationFactory<Startup>();

            Client = Factory.WithWebHostBuilder(builder =>
            {
                builder.ConfigureTestServices(services =>
                {
                    // add services
                });
            }).CreateClient(new WebApplicationFactoryClientOptions
            {

            });
        }
    }
}
