using FluentAssertions;
using src.BowlingGameKata;
using Xunit;

namespace TestDrivenDevelopment.BowlingGameKata
{
    public class BowlingTests
    {
        Game g = new Game();

        [Fact]
        public void Should_return_zero_when_zero_poin()
        {
            // Arrange
            for (int i = 0; i < 20; i++)
            {
                g.Roll(0);
            }

            // Act
            int result = g.Score();

            // Assert
            result.Should().Be(0);
        }

        [Fact]
        public void Should1()
        {
            // Arrange
            for (int i = 0; i < 20; i++)
            {
                g.Roll(1);
            }

            // Act
            int result = g.Score();

            // Assert
            result.Should().Be(20);
        }

    }
}
