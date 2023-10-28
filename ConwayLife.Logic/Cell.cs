namespace ConwayLife.Logic;

public class Cell
{
    public readonly int i;
    public readonly int j;
    public bool isAlive;

    public int AliveNeighbours => neighbours!.Count(cell => cell.isAlive);

    internal List<Cell>? neighbours;

    public Cell(int i, int j)
    {
        this.i = i;
        this.j = j;
    }
}