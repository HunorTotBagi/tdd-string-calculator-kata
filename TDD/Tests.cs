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

        [Fact]
        public void Should_return_the_sum_of_two_numbers_2()
        {
            // Arrage
            StringCalculator calculator = new StringCalculator();

            // Act
            int result = calculator.Add("1,2");

            // Assert
            result.Should().Be(3);
        }

        [Fact]
        public void Should_return_the_sum_of_two_numbers_1()
        {
            // Arrage
            StringCalculator calculator = new StringCalculator();

            // Act
            int result = calculator.Add("5,7");

            // Assert
            result.Should().Be(12);
        }

        [Fact]
        public void Shoulder_return_the_sum_of_unknown_amount_of_numbers()
        {
            // Arrage
            StringCalculator calculator = new StringCalculator();

            // Act
            int result = calculator.Add("2,4,6,7,8,9,4,2");

            // Assert
            result.Should().Be(42);
        }

        [Fact]
        public void Shoulder_appect_new_line_as_delimiter()
        {
            // Arrage
            StringCalculator calculator = new StringCalculator();

            // Act
            int result = calculator.Add("1\n2,3");

            // Assert
            result.Should().Be(6);
        }

        [Fact]
        public void Shoulder_support_different_delimiters_1()
        {
            // Arrage
            StringCalculator calculator = new StringCalculator();

            // Act
            int result = calculator.Add(";\n1;2");

            // Assert
            result.Should().Be(3);
        }

        [Fact]
        public void Shoulder_throw_exception_message_when_calling_with_negative_number()
        {
            // Arrage
            StringCalculator calculator = new StringCalculator();

            // Act
            Action act = () => calculator.Add("1,-5,3");

            // Assert
            act.Should().Throw<ArgumentException>()
                .WithMessage("Negatives not allowed: -5");
        }
        [Fact]
        public void Shoulder_throw_exception_message_when_calling_with_negative_number_1()
        {
            // Arrage
            StringCalculator calculator = new StringCalculator();

            // Act
            Action act = () => calculator.Add("1,-5,3, -6");

            // Assert
            act.Should().Throw<ArgumentException>()
                .WithMessage("Negatives not allowed: -5, -6");
        }
    }
}