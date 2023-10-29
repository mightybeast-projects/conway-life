namespace ConwayLife.Logic.Main;

public class Life
{
    public Grid grid { get; private set; }
    public int generation;

    private readonly List<ILifeObserver> observers;
    private List<Cell>? mutatedCells;

    public Life(int gridWidth, int gridHeight)
    {
        grid = new(gridWidth, gridHeight);
        observers = new();
    }

    public void Subscribe(ILifeObserver observer) => observers.Add(observer);

    public void SpawnCell(int i, int j) => grid.cells[i, j].IsAlive = true;

    public void KillCell(int i, int j) => grid.cells[i, j].IsAlive = false;

    public void ClearGrid()
    {
        for (int i = 0; i < grid.width; i++)
            for (int j = 0; j < grid.height; j++)
                KillCell(i, j);
    }

    public void Mutate()
    {
        mutatedCells = new List<Cell>();

        for (int i = 0; i < grid.width; i++)
            for (int j = 0; j < grid.height; j++)
                MutateCell(grid.cells[i, j]);

        mutatedCells.ForEach(cell =>
            grid.cells[cell.i, cell.j].IsAlive = cell.IsAlive);

        generation++;

        NotifyObservers();
    }

    private void MutateCell(Cell cell)
    {
        var mutatedCell = (Cell)cell.Clone();

        if (cell.LivesOn || cell.Reproducted)
            mutatedCell.IsAlive = true;
        else if (cell.IsOverpopulated || cell.IsUnderpopulated)
            mutatedCell.IsAlive = false;

        if (mutatedCell.IsAlive != cell.IsAlive)
            mutatedCells!.Add(mutatedCell);
    }

    private void NotifyObservers() => observers.ForEach(o => o.Notify());
}