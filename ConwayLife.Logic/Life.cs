namespace ConwayLife.Logic;

public class Life
{
    public readonly Grid grid;

    public Life(int gridWidth, int gridHeight) =>
        grid = new(gridWidth, gridHeight);

    public void SpawnAliveCell(int i, int j) => grid.cells[i, j].alive = true;

    public void Mutate()
    {
        for (int i = 0; i < grid.width; i++)
            for (int j = 0; j < grid.height; j++)
                MutateCell(grid.cells[i, j]);
    }

    private void MutateCell(Cell cell)
    {

    }
}