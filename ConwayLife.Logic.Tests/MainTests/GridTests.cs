using ConwayLife.Logic.Main;
using FluentAssertions;

namespace ConwayLife.Logic.Tests.MainTests;

[TestFixture]
public class GridTests
{
    [Test]
    public void GridInit_IsCorrect()
    {
        var grid = new Grid(10, 10);

        grid.width.Should().Be(10);
        grid.height.Should().Be(10);

        grid.cells.GetLength(0).Should().Be(10);
        grid.cells.GetLength(1).Should().Be(10);

        grid.cells[0, 0].neighbours!.Should().NotBeNull();
        grid.cells[0, 0].neighbours!.Count.Should().Be(3);
        grid.cells[0, 0].neighbours!.Should().Contain(grid.cells[0, 1]);
    }
}