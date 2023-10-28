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

        InitializeTiles();
    }

    private void InitializeTiles()
    {
        for (int i = 0; i < tiles.GetLength(0); i++)
            for (int j = 0; j < tiles.GetLength(1); j++)
                tiles[i, j] = new(i, j);

        for (int i = 0; i < tiles.GetLength(0); i++)
            for (int j = 0; j < tiles.GetLength(1); j++)
                AddNeighboursFor(tiles[i, j]);
    }

    private void AddNeighboursFor(Tile tile)
    {
        tile.neighbours = new List<Tile>();

        var minI = Math.Max(0, tile.i - 1);
        var maxI = Math.Min(tile.i + 1, tiles.GetLength(0) - 1);

        var minJ = Math.Max(0, tile.j - 1);
        var maxJ = Math.Min(tile.j + 1, tiles.GetLength(1) - 1);

        for (int i = minI; i <= maxI; i++)
            for (int j = minJ; j <= maxJ; j++)
                AddNeighbourFor(tile, i, j);
    }

    private void AddNeighbourFor(Tile tile, int i, int j)
    {
        var neighbour = tiles[i, j];

        if (neighbour == tile)
            return;

        tile.neighbours!.Add(neighbour);
    }
}