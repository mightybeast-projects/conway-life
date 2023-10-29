namespace ConwayLife.Logic.Main;

public class Cell : ICloneable
{
    public readonly int i;
    public readonly int j;
    public bool IsAlive
    {
        get { return _isAlive; }
        set
        {
            _isAlive = value;
            NotifyObserver();
        }
    }
    public bool IsUnderpopulated => IsAlive && AliveNeighbours < 2;
    public bool IsOverpopulated => IsAlive && AliveNeighbours > 3;
    public bool LivesOn =>
        IsAlive && (AliveNeighbours == 2 || AliveNeighbours == 3);
    public bool Reproducted => !IsAlive && AliveNeighbours == 3;
    public int AliveNeighbours => neighbours!.Count(cell => cell.IsAlive);

    internal List<Cell>? neighbours;

    private ICellObserver? observer;
    private bool _isAlive;

    public Cell(int i, int j)
    {
        this.i = i;
        this.j = j;
    }

    public void Subscribe(ICellObserver observer) => this.observer = observer;

    private void NotifyObserver() => observer?.Notify();

    public object Clone() => MemberwiseClone();
}