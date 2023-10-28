using ConwayLife.Logic;
using FluentAssertions;

namespace ConwayLife.Tests;

[TestFixture]
public class CellTests
{
    [Test]
    public void CellInitIsCorrect()
    {
        var cell = new Cell(1, 2);

        cell.i.Should().Be(1);
        cell.j.Should().Be(2);
        cell.alive.Should().BeFalse();
        cell.neighbours.Should().BeNullOrEmpty();
    }
}