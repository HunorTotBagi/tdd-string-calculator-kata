// Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)
// - HH = hours, padded to 2 digits, range: 00 – 99
// - MM = minutes, padded to 2 digits, range: 00 – 59
// - SS = seconds, padded to 2 digits, range: 00 – 59
// The maximum time never exceeds 359_999 (99:59:59).

using FluentAssertions;
using StringCalculatorKata.HumanReadableTime;
using Xunit;

namespace TestDrivenDevelopment.HumanReadableTimeTest
{
    public class HumanReadableTimeTests
    {
        [Theory]
        [InlineData(0, "00:00:00")]
        [InlineData(5, "00:00:05")]
        [InlineData(60, "00:01:00")]
        [InlineData(3_600, "01:00:00")]
        [InlineData(86_399, "23:59:59")]
        [InlineData(359_999, "99:59:59")]
        [InlineData(369_999, "00:00:00")]
        [InlineData(-555, "00:00:00")]
        public void Should_return_human_readable_time(int input, string expected)
        {
            // Arrange

            // Act
            var result = HumanReadableTime.Convert(input);

            // Assert
            result.Should().Be(expected);
        }
    }
}
