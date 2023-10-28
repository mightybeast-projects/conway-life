namespace ConwayLife.Logic;

public class Life
{
    public Grid grid { get; private set; }

    private Grid nextGenerationGrid;

    public Life(int gridWidth, int gridHeight)
    {
        grid = new(gridWidth, gridHeight);
        nextGenerationGrid = grid;
    }

    public void SpawnAliveCell(int i, int j) => grid.cells[i, j].isAlive = true;

    public void Mutate()
    {
        nextGenerationGrid = grid;

        for (int i = 0; i < grid.width; i++)
            for (int j = 0; j < grid.height; j++)
                MutateCell(grid.cells[i, j]);

        grid = nextGenerationGrid;
    }

    private void MutateCell(Cell cell)
    {
        if (cell.AliveNeighbours < 2 || cell.AliveNeighbours > 3)
            nextGenerationGrid.cells[cell.i, cell.j].isAlive = false;
        else if (!cell.isAlive && cell.AliveNeighbours == 3)
            nextGenerationGrid.cells[cell.i, cell.j].isAlive = true;
    }
}