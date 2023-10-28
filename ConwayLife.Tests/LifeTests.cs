using ConwayLife.Logic;
using FluentAssertions;

namespace ConwayLife.Tests;

[TestFixture]
public class LifeTests
{
    private Life life;

    [SetUp]
    public void SetUp() => life = new Life(10, 10);

    [Test]
    public void LifeInit_IsCorrect()
    {
        life.grid.width.Should().Be(10);
        life.grid.height.Should().Be(10);
    }

    [Test]
    public void Life_CanSpawn_AliveCell()
    {
        life.SpawnAliveCell(0, 0);

        life.grid.cells[0, 0].isAlive.Should().BeTrue();
    }

    [Test]
    public void DeadLifeGrid_ShouldNot_Mutate()
    {
        var deadLifeGrid = life.grid;

        life.Mutate();

        life.grid.Should().BeEquivalentTo(deadLifeGrid);
    }

    [Test]
    public void Cell_ShouldDie_By_Underpopulation()
    {
        life.SpawnAliveCell(0, 0);

        life.Mutate();

        life.grid.cells[0, 0].isAlive.Should().BeFalse();
    }

    [Test]
    public void Cell_ShouldDie_By_Overpopulation()
    {
        life.SpawnAliveCell(0, 0);
        life.SpawnAliveCell(0, 1);
        life.SpawnAliveCell(0, 2);
        life.SpawnAliveCell(1, 0);
        life.SpawnAliveCell(1, 1);

        life.Mutate();

        life.grid.cells[0, 1].isAlive.Should().BeFalse();
    }
}