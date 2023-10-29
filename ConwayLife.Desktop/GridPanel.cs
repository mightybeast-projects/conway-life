using ConwayLife.Logic;
using Microsoft.Xna.Framework;
using Myra.Graphics2D;
using Myra.Graphics2D.Brushes;
using Myra.Graphics2D.UI;

using Grid = Myra.Graphics2D.UI.Grid;

namespace ConwayLife.Desktop;

public class LifeGrid : Grid
{
    private const int tileSize = 20;
    private readonly Life life;

    public LifeGrid(Life life)
    {
        this.life = life;

        Width = life.grid.width * tileSize + 3;
        Height = life.grid.height * tileSize + 3;

        ShowGridLines = true;
        GridLinesColor = Color.DarkOrange;
        Border = new SolidBrush(Color.DarkOrange);
        BorderThickness = new Thickness(2);

        UpdateContent();
    }

    private void UpdateContent()
    {
        Widgets.Clear();

        AddProportions();
        AddCells();
    }

    private void AddProportions()
    {
        for (int i = 0; i < life.grid.height; i++)
            RowsProportions.Add(GridProportion);

        for (int i = 0; i < life.grid.width; i++)
            ColumnsProportions.Add(GridProportion);
    }

    private void AddCells()
    {
        for (int i = 0; i < life.grid.width; i++)
            for (int j = 0; j < life.grid.height; j++)
                AddCell(life.grid.cells[i, j]);
    }

    private void AddCell(Cell cell)
    {
        if (cell.isAlive)
            Widgets.Add(new AliveCell(life, cell));
        else
            Widgets.Add(new DeadCell(life, cell));
    }

    private Proportion GridProportion => new Proportion()
    {
        Type = ProportionType.Pixels,
        Value = tileSize
    };
}