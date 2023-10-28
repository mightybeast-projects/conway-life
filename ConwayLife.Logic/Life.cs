namespace ConwayLife.Logic;

public class Life
{
    public readonly Grid grid;

    public Life(int gridWidth, int gridHeight) =>
        grid = new(gridWidth, gridHeight);
}