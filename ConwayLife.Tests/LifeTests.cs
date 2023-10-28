using ConwayLife.Logic;
using FluentAssertions;

namespace ConwayLife.Tests;

[TestFixture]
public class LifeTests
{
    [Test]
    public void LifeInitIsCorrect()
    {
        var life = new Life(10, 10);

        life.grid.width.Should().Be(10);
        life.grid.height.Should().Be(10);
    }
}