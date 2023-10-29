using ConwayLife.Logic;
using FluentAssertions;

namespace ConwayLife.Tests;

[TestFixture]
public class CellTests
{
    [Test]
    public void CellInit_IsCorrect()
    {
        var cell = new Cell(1, 2);

        cell.i.Should().Be(1);
        cell.j.Should().Be(2);
        cell.isAlive.Should().BeFalse();
        cell.neighbours.Should().BeNullOrEmpty();
    }

    [Test]
    public void Cell_ShouldKnow_AliveNeighbours()
    {
        var life = new Life(10, 10);

        life.SpawnCell(0, 1);

        life.grid.cells[0, 0].AliveNeighbours.Should().Be(1);
    }
}