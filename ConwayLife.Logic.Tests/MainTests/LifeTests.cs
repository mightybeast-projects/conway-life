using ConwayLife.Logic.Main;
using FluentAssertions;

namespace ConwayLife.Logic.Tests.MainTests;

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
    public void Life_CanSpawnCell()
    {
        life.SpawnCell(0, 0);

        life.grid.cells[0, 0].isAlive.Should().BeTrue();
    }

    [Test]
    public void Life_CanClearGrid()
    {
        life.SpawnCell(0, 0);
        life.ClearGrid();

        life.grid.cells[0, 0].isAlive.Should().BeFalse();
    }

    [Test]
    public void Life_CanKillCell()
    {
        life.SpawnCell(0, 0);
        life.KillCell(0, 0);

        life.grid.cells[0, 0].isAlive.Should().BeFalse();
    }

    [Test]
    public void Life_ShouldHave_Generation()
    {
        life.generation.Should().Be(0);

        life.Mutate();

        life.generation.Should().Be(1);
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
        life.SpawnCell(0, 0);

        life.Mutate();

        life.grid.cells[0, 0].isAlive.Should().BeFalse();
    }

    [Test]
    public void Cell_ShouldDie_By_Overpopulation()
    {
        life.SpawnCell(0, 0);
        life.SpawnCell(0, 1);
        life.SpawnCell(0, 2);
        life.SpawnCell(1, 0);
        life.SpawnCell(1, 1);

        life.Mutate();

        life.grid.cells[0, 1].isAlive.Should().BeFalse();
    }

    [Test]
    public void Cell_Should_LiveOn()
    {
        life.SpawnCell(0, 0);
        life.SpawnCell(0, 1);
        life.SpawnCell(1, 0);
        life.SpawnCell(1, 1);

        life.Mutate();

        life.grid.cells[0, 0].isAlive.Should().BeTrue();
        life.grid.cells[0, 1].isAlive.Should().BeTrue();
        life.grid.cells[1, 0].isAlive.Should().BeTrue();
        life.grid.cells[1, 1].isAlive.Should().BeTrue();
    }

    [Test]
    public void Cell_ShouldBe_Reproducted()
    {
        life.SpawnCell(0, 1);
        life.SpawnCell(1, 0);
        life.SpawnCell(1, 1);

        life.Mutate();

        life.grid.cells[0, 0].isAlive.Should().BeTrue();
    }
}