using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TheMaze;

namespace TheMaze.Tests
{
    public class UnitTests
    {
        [Fact]
        public void Test_CalculateScore()
        {
            int expected = 6;
            int actual = Maze.CalculateScore(3, 3);

            Assert.Equal(expected, actual);
        }

    }
}
