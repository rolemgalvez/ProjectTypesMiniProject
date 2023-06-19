using HomeworkTwentySix.Library;
using Xunit;

namespace HomeworkTwentySix.Tests
{
    public class ComputeTests
    {
        [Fact]
        public void ShouldReturn5()
        {
            // Arrange
            Compute compute = new Compute();
            double expected = 5;

            // Act
            double actual = compute.Add(1, 4);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 0, 10)]
        [InlineData(100, 10, 110)]
        [InlineData(69, 11, 80)]
        public void ShouldReturnCorrectSum(double x, double y, double expected)
        {
            // Arrange
            Compute compute = new Compute();

            // Act
            double actual = compute.Add(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
