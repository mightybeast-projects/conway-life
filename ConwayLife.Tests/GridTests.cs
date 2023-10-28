using ConwayLife.Logic;
using FluentAssertions;

namespace ConwayLife.Tests;

[TestFixture]
public class GridTests
{
    [Test]
    public void GridInitIsCorrect()
    {
        var grid = new Grid(10, 10);

        grid.width.Should().Be(10);
        grid.height.Should().Be(10);

        grid.tiles.GetLength(0).Should().Be(10);
        grid.tiles.GetLength(1).Should().Be(10);

        grid.tiles[0, 0].neighbours!.Should().NotBeNull();
        grid.tiles[0, 0].neighbours!.Count.Should().Be(3);
        grid.tiles[0, 0].neighbours!.Should().Contain(grid.tiles[0, 1]);
    }
}