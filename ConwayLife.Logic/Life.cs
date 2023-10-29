namespace ConwayLife.Logic;

public class Life
{
    public Grid grid { get; private set; }
    public int generation;

    private readonly List<ILifeObserver> observers;
    private Grid? nextGenerationGrid;

    public Life(int gridWidth, int gridHeight)
    {
        grid = new(gridWidth, gridHeight);
        observers = new();
    }

    public void Subscribe(ILifeObserver observer) => observers.Add(observer);

    public void SpawnCell(int i, int j)
    {
        grid.cells[i, j].isAlive = true;

        NotifyObservers();
    }

    public void KillCell(int i, int j)
    {
        grid.cells[i, j].isAlive = false;

        NotifyObservers();
    }

    public void ClearGrid()
    {
        grid = new(grid.width, grid.height);

        NotifyObservers();
    }

    public void Mutate()
    {
        nextGenerationGrid = new Grid(grid.width, grid.height);

        for (int i = 0; i < grid.width; i++)
            for (int j = 0; j < grid.height; j++)
                MutateCell(grid.cells[i, j]);

        grid = nextGenerationGrid;

        generation++;

        NotifyObservers();
    }

    private void MutateCell(Cell cell)
    {
        if (cell.LivesOn || cell.Reproducted)
            nextGenerationGrid!.cells[cell.i, cell.j].isAlive = true;
        else if (cell.IsOverpopulated || cell.IsUnderpopulated)
            nextGenerationGrid!.cells[cell.i, cell.j].isAlive = false;
    }

    private void NotifyObservers() => observers.ForEach(o => o.Notify());
}