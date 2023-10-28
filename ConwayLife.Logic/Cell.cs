namespace ConwayLife.Logic;

public class Cell
{
    public readonly int i;
    public readonly int j;
    public bool alive;

    internal List<Cell>? neighbours;

    public Cell(int i, int j)
    {
        this.i = i;
        this.j = j;
    }
}