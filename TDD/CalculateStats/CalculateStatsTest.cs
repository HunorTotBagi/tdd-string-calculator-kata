using FluentAssertions;
using src.KATA;
using Xunit;

// Process a sequence of integer numbers to determine the following statistics:
// * minimum value
// * maximum value
// * number of elements in the sequence
// * average value

namespace test.KATA
{
    public class CalculateStatsTest
    {
        readonly CalculateStats sequence = new(new int[] { 1, 4, -6, 100 });

        [Fact]
        public void Should_return_minimum_value()
        {
            // Arrange

            // Act

            // Assert
            sequence.Minimum.Should().Be(-6);
        }

        [Fact]
        public void Should_return_maximum_value()
        {
            // Arrange

            // Act

            // Assert
            sequence.Maximum.Should().Be(100);
        }

        [Fact]
        public void Should_return_number_of_elements()
        {
            // Arrange

            // Act

            // Assert
            sequence.NumberOfElements.Should().Be(4);
        }

        [Fact]
        public void Should_return_average_value()
        {
            // Arrange

            // Act

            // Assert
            sequence.Average.Should().Be(24.75);
        }
    }
}