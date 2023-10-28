using ConwayLife.Logic;
using FluentAssertions;

namespace ConwayLife.Tests;

[TestFixture]
public class TileTests
{
    [Test]
    public void TileInitIsCorrect()
    {
        var tile = new Tile(1, 2);

        tile.i.Should().Be(1);
        tile.j.Should().Be(2);
        tile.alive.Should().BeFalse();
        tile.neighbours.Should().BeNullOrEmpty();
    }
}