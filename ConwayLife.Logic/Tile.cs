namespace ConwayLife.Logic;

public class Tile
{
    public readonly int i;
    public readonly int j;
    public bool alive;

    internal List<Tile>? neighbours;

    public Tile(int i, int j)
    {
        this.i = i;
        this.j = j;
    }
}