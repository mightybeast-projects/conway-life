using ConwayLife.Logic;
using FluentAssertions;

namespace ConwayLife.Tests;

[TestFixture]
public class TileTests
{
    [Test]
    public void TileInitIsCorrect()
    {
        Tile tile = new();

        tile.alive.Should().BeFalse();
        tile.neighbours.Should().BeNullOrEmpty();
    }
}