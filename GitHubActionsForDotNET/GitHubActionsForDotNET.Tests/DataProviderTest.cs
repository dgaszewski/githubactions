using Xunit;

namespace GitHubActionsForDotNET.Tests
{
    public class DataProviderTest
    {
        [Fact]
        public void Returns_higher_number_than_argument()
        {
            // Arrange
            IDataProvider sut = new MockedDataProvider();
            int argument = 2;

            // Act
            var result = sut.GenerateNumber(2);

            // Assert
            Assert.True(result > argument);
        }
    }
}