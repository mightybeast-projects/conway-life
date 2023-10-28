namespace ConwayLife.Logic;

public class Grid
{
    public readonly Tile[,] tiles;
    public readonly int width;
    public readonly int height;

    public Grid(int width, int height)
    {
        this.width = width;
        this.height = height;

        tiles = new Tile[width, height];
    }
}