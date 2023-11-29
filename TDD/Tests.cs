using FluentAssertions;
using StringCalculatorKata;

namespace TestDrivenDevelopment
{
    public class Tests
    {
        private static StringCalculator CreateCalculator()
        {
            return new StringCalculator();
        }

        StringCalculator calculator = CreateCalculator();

        [Fact]
        public void Should_return_zero_when_empty_string_is_given()
        {
            // Act
            int result = calculator.Add("");

            // Assert
            result.Should().Be(0);
        }

        // Check for multiple digit numbers
        // Numbers that are greater than the max int
        [Fact]
        public void Should_return_the_exact_number()
        {
            // Act
            int result = calculator.Add("1");

            // Assert
            result.Should().Be(1);
        }

        // Also chekc if the sum is greater than the max integer
        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("5,7", 12)]
        [InlineData("15,25", 40)]
        public void Should_return_the_sum_of_two_numbers(string input, int expectedResult)
        {
            // Act
            int result = calculator.Add(input);

            // Assert
            result.Should().Be(expectedResult);
        }


        [Fact]
        public void Shoulder_return_the_sum_of_unknown_amount_of_numbers()
        {
            // Act
            int result = calculator.Add("2,4,6,7,8,9,4,2");

            // Assert
            result.Should().Be(42);
        }

        [Fact]
        public void Shoulder_appect_new_line_as_delimiter()
        {
            // Act
            int result = calculator.Add("1\n2,3");

            // Assert
            result.Should().Be(6);
        }

        [Theory]
        [InlineData(";\n1;2", 3)]
        [InlineData("&1&2,8", 11)]
        public void Should_support_different_delimiters(string input, int expected)
        {
            // Act
            int result = calculator.Add(input);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("1,-5,3", "Negatives not allowed: -5")]
        [InlineData("1,-5,3, -6", "Negatives not allowed: -5, -6")]
        [InlineData("1\n-5\n3\n -2", "Negatives not allowed: -5, -2")]
        public void Shoulder_throw_exception_message_when_calling_with_negative_number(string input, string expectedErrorMessage)
        {
            // Act
            Action act = () => calculator.Add(input);

            // Assert
            act.Should().Throw<ArgumentException>().WithMessage(expectedErrorMessage);
        }
    }
}