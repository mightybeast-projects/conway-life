namespace ConwayLife.Logic;

public class Cell
{
    public readonly int i;
    public readonly int j;
    public bool isAlive;

    public bool IsUnderpopulated => isAlive && AliveNeighbours < 2;
    public bool IsOverpopulated => isAlive && AliveNeighbours > 3;
    public bool LivesOn =>
        isAlive && (AliveNeighbours == 2 || AliveNeighbours == 3);
    public bool Reproducted => !isAlive && AliveNeighbours == 3;
    public int AliveNeighbours => neighbours!.Count(cell => cell.isAlive);

    internal List<Cell>? neighbours;

    public Cell(int i, int j)
    {
        this.i = i;
        this.j = j;
    }
}