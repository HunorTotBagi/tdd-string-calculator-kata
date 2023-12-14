using FluentAssertions;
using src.BowlingGameKata;
using Xunit;

namespace TestDrivenDevelopment.BowlingGameKata
{
    public class BowlingTests
    {
        Game g = new Game();

        private void RollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
            {
                g.Roll(pins);
            }
        }

        [Fact]
        public void Test_gutter_game()
        {
            // Arrange
            RollMany(20, 0);

            // Act
            int result = g.Score();

            // Assert
            result.Should().Be(0);
        }

        [Fact]
        public void Test_all_ones()
        {
            // Arrange
            RollMany(20, 1);

            // Act
            int result = g.Score();

            // Assert
            result.Should().Be(20);
        }
    }
}
