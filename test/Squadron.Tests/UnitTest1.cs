using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Squadron.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async Task GivenGETRequest_WhenCorrectRequest_ThenReturnStatusCodeOK()
        {
            // arrange
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5000");

            // act            
            var result = await client.GetAsync("/version");

            // assert
            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
        }

        [Theory]
        [InlineData("pawel")]
        [InlineData("jon")]
        [InlineData("joe")]
        public async Task GivenGETRequestWithParameter_WhenCorrectRequest_ThenReturnStatusCodeOK(string givenParameter)
        {
            //arrange
            var httpClient = new HttpClient();
            var baseUrl = new Uri("http://localhost:5000");
            httpClient.BaseAddress = baseUrl;

            //act
            var result = await httpClient.GetAsync($"/users/{givenParameter}");

            //assert
            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
        }

        [Fact]
        public async Task GivenPOSTRequest_WhenCorrectRequest_ThenReturnStatusCodeOK()
        {
            // arrange
            var httpClient = new HttpClient();
            var baseUrl = new Uri("http://localhost:5000");
            httpClient.BaseAddress = baseUrl;
            var requestBody = new StringContent("");

            // act
            var result = await httpClient.PostAsync("users/pawel", requestBody);

            // assert
            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
        }

        [Fact]
        public async Task GivenPUTRequest_WhenCorrectRequest_ThenReturnStatusCodeCreated()
        {
            // arrange
            var httpClient = new HttpClient();
            var baseUrl = new Uri("http://localhost:5000");
            httpClient.BaseAddress = baseUrl;
            var requestBody = new StringContent("");

            // act
            var result = await httpClient.PutAsync("users", requestBody);

            // assert
            Assert.Equal(HttpStatusCode.Created, result.StatusCode);
        }
    }
}
