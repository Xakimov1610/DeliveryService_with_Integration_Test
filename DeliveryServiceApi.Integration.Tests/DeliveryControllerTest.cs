using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceApi.Integration.Tests
{
    [TestFixture]
    public class DeliveryControllerTest
    {
        [Test]
        public async Task CheckStatus_SendRequest_ShouldReturnOk()
        {
            // Arrange

            WebApplicationFactory<Startup> webHost = new WebApplicationFactory<Startup>().WithWebHostBuilder(_ => { });

            HttpClient httpClient = webHost.CreateClient();


            // Act

            HttpResponseMessage response = await httpClient.GetAsync(requestUri: "api/delivery/check-status");

            // Assert

            Assert.AreEqual(expected: HttpStatusCode.OK, actual: response.StatusCode);
        }
    }
}
