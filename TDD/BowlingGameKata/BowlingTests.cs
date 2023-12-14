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

            // Assert
            g.Score().Should().Be(0);
        }

        [Fact]
        public void Test_all_ones()
        {
            // Arrange
            RollMany(20, 1);

            // Assert
            g.Score().Should().Be(20);
        }

        [Fact]
        public void Test_one_spare()
        {
            RollSpare();
            g.Roll(3);
            RollMany(17, 0);

            g.Score().Should().Be(16);
        }

        [Fact]
        public void Test_one_strike()
        {
            RollStrike();
            g.Roll(3);
            g.Roll(4);
            RollMany(16, 0);
            g.Score().Should().Be(24);
        }

        private void RollStrike()
        {
            g.Roll(10);
        }

        private void RollSpare()
        {
            g.Roll(5);
            g.Roll(5);
        }
    }
}
