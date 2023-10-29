namespace ConwayLife.Logic.Main;

public class Grid
{
    public readonly Cell[,] cells;
    public readonly int width;
    public readonly int height;

    public Grid(int width, int height)
    {
        this.width = width;
        this.height = height;

        cells = new Cell[width, height];

        InitializeCells();
    }

    private void InitializeCells()
    {
        for (int i = 0; i < cells.GetLength(0); i++)
            for (int j = 0; j < cells.GetLength(1); j++)
                cells[i, j] = new(i, j);

        for (int i = 0; i < cells.GetLength(0); i++)
            for (int j = 0; j < cells.GetLength(1); j++)
                AddNeighboursFor(cells[i, j]);
    }

    private void AddNeighboursFor(Cell cell)
    {
        cell.neighbours = new();

        var minI = Math.Max(0, cell.i - 1);
        var maxI = Math.Min(cell.i + 1, cells.GetLength(0) - 1);

        var minJ = Math.Max(0, cell.j - 1);
        var maxJ = Math.Min(cell.j + 1, cells.GetLength(1) - 1);

        for (int i = minI; i <= maxI; i++)
            for (int j = minJ; j <= maxJ; j++)
                AddNeighbourFor(cell, i, j);
    }

    private void AddNeighbourFor(Cell cell, int i, int j)
    {
        var neighbour = cells[i, j];

        if (neighbour == cell)
            return;

        cell.neighbours!.Add(neighbour);
    }
}