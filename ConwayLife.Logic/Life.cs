namespace ConwayLife.Logic;

public class Life
{
    public Grid grid { get; private set; }
    public int generation;

    private Grid? nextGenerationGrid;

    public Life(int gridWidth, int gridHeight) =>
        grid = new(gridWidth, gridHeight);

    public void SpawnCell(int i, int j) => grid.cells[i, j].isAlive = true;

    public void KillCell(int i, int j) => grid.cells[i, j].isAlive = false;

    public void ClearGrid() => grid = new(grid.width, grid.height);

    public void Mutate()
    {
        nextGenerationGrid = new Grid(grid.width, grid.height);

        for (int i = 0; i < grid.width; i++)
            for (int j = 0; j < grid.height; j++)
                MutateCell(grid.cells[i, j]);

        grid = nextGenerationGrid;

        generation++;
    }

    private void MutateCell(Cell cell)
    {
        if (cell.LivesOn || cell.Reproducted)
            nextGenerationGrid!.cells[cell.i, cell.j].isAlive = true;
        else if (cell.IsOverpopulated || cell.IsUnderpopulated)
            nextGenerationGrid!.cells[cell.i, cell.j].isAlive = false;
    }
}