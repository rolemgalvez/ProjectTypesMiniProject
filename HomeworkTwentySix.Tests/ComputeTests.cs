using HomeworkTwentySix.Library;
using Xunit;

namespace HomeworkTwentySix.Tests
{
    public class ComputeTests
    {
        [Fact]
        public void ShouldReturnSum5()
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

        [Fact]
        public void ShouldReturnDifference10()
        {
            // Arrange
            Compute compute = new Compute();
            double expected = 10;

            // Act
            double actual = compute.Subtract(20, 10);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(200, 0, 200)]
        [InlineData(500, 100, 400)]
        [InlineData(1000, 500, 500)]
        public void ShouldReturnCorrectDifference(double x, double y, double expected)
        {
            // Arrange
            Compute compute = new Compute();

            // Act
            double actual = compute.Subtract(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnProduct20()
        {
            // Arrange
            Compute compute = new Compute();
            double expected = 20;

            // Act
            double actual = compute.Multiply(5, 4);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 0, 0)]
        [InlineData(200, 2, 400)]
        [InlineData(1000, 500, 500)]
        public void ShouldReturnCorrectProduct(double x, double y, double expected)
        {
            // Arrange
            Compute compute = new Compute();

            // Act
            double actual = compute.Multiply(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnDividend30()
        {
            // Arrange
            Compute compute = new Compute();
            double expected = 30;

            // Act
            double actual = compute.Divide(210, 7);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(100, 10, 10)]
        [InlineData(700, 1, 700)]
        [InlineData(500, 500, 1)]
        public void ShouldReturnCorrectDividend(double x, double y, double expected)
        {
            // Arrange
            Compute compute = new Compute();

            // Act
            double actual = compute.Divide(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
