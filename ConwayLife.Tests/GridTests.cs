using ConwayLife.Logic;
using FluentAssertions;

namespace ConwayLife.Tests;

[TestFixture]
public class GridTests
{
    [Test]
    public void GridInitIsCorrect()
    {
        Grid grid = new(5, 10);

        grid.width.Should().Be(5);
        grid.height.Should().Be(10);
        grid.tiles.GetLength(0).Should().Be(5);
        grid.tiles.GetLength(1).Should().Be(10);
    }
}