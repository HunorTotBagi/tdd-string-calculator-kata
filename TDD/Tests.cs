using FluentAssertions;
using StringCalculatorKata;

namespace TestDrivenDevelopment
{
    public class Tests
    {
        [Fact]
        public void Should_return_zero_when_empty_string_is_given()
        {
            // Arrange
            StringCalculator calculator = new StringCalculator();

            // Act
            int result = calculator.Add("");

            // Assert
            result.Should().Be(0);
        }

        [Fact]
        public void Should_return_the_exact_number()
        {
            // Arrage
            StringCalculator calculator = new StringCalculator();

            // Act
            int result = calculator.Add("1");

            // Assert
            result.Should().Be(1);
        }
    }
}