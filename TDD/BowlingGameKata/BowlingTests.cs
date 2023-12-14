using FluentAssertions;
using src.BowlingGameKata;
using Xunit;

namespace TestDrivenDevelopment.BowlingGameKata
{
    public class BowlingTests
    {
        Game g = new Game();

        [Fact]
        public void Should()
        {
            // Arrange
            for (int i = 0; i < 20; i++)
            {
                g.roll(0);
            }

            // Act
            int result = g.score();

            // Assert
            result.Should().Be(0);
        }


    }
}
