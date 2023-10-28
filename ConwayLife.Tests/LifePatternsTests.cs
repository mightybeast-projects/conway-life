using ConwayLife.Logic;
using FluentAssertions;

namespace ConwayLife.Tests;

[TestFixture]
public class LifePatternsTests
{
    private Life life;
    private Grid startingGrid;

    [SetUp]
    public void SetUp()
    {
        life = new Life(10, 10);
        startingGrid = life.grid;
    }

    [Test]
    public void Block_IsCorrect()
    {
        life.SpawnAliveCell(0, 0);
        life.SpawnAliveCell(0, 1);
        life.SpawnAliveCell(1, 0);
        life.SpawnAliveCell(1, 1);

        life.Mutate();

        life.grid.Should().BeEquivalentTo(startingGrid);
    }

    [Test]
    public void Bee_HiveTest_IsCorrect()
    {
        life.SpawnAliveCell(0, 1);
        life.SpawnAliveCell(1, 0);
        life.SpawnAliveCell(2, 0);
        life.SpawnAliveCell(1, 2);
        life.SpawnAliveCell(2, 2);
        life.SpawnAliveCell(3, 1);

        life.Mutate();

        life.grid.Should().BeEquivalentTo(startingGrid);
    }

    [Test]
    public void Tub_IsCorrect()
    {
        life.SpawnAliveCell(0, 1);
        life.SpawnAliveCell(1, 0);
        life.SpawnAliveCell(1, 2);
        life.SpawnAliveCell(2, 1);

        life.Mutate();

        life.grid.Should().BeEquivalentTo(startingGrid);
    }
}