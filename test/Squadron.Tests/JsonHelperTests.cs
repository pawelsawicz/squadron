using Xunit;

namespace Squadron.Tests
{
    public class JsonHelperTests
    {
        [Fact]
        public void GivenDeserializeWhenStringValidThenReturnObject()
        {
            // arrange
            var jsonToRead = "{\"url\" : \"http://localhost:5000\", \"verb\" : \"get\" }";
            var expectedUrl = "http://localhost:5000";
            var expectedVerb = "get";
            // act

            // pass camel case convenction
            var result = JsonHelper.Deserialize<ClassUnderTest>(jsonToRead);

            // assert
            Assert.NotNull(result);
            Assert.Equal(expectedUrl, result.url);
            Assert.Equal(expectedVerb, result.verb);
        }

        [Fact]
        public void GivenDeserializeWhenStringInvalidReturnNull()
        {
            var jsonToRead = "{ }";
            // act

            // pass camel case convenction
            var result = JsonHelper.Deserialize<ClassUnderTest>(jsonToRead);

            // assert
            Assert.NotNull(result);
        }
    }

    public class ClassUnderTest
    {
        public string url { get; set; }

        public string verb { get; set; }
    }
}