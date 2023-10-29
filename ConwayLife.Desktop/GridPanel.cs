using Microsoft.Xna.Framework;
using Myra.Graphics2D;
using Myra.Graphics2D.Brushes;
using Myra.Graphics2D.UI;

namespace ConwayLife.Desktop;

public class GridPanel : Panel
{
    private Grid mainGrid;

    public GridPanel()
    {
        Width = 1000 + 3;
        Height = 500 + 3;
        Border = new SolidBrush(Color.DarkOrange);
        BorderThickness = new Thickness(2);

        UpdateContent();
    }

    private void UpdateContent()
    {
        Widgets.Clear();

        mainGrid = new Grid()
        {
            ShowGridLines = true,
            GridLinesColor = Color.DarkOrange
        };

        AddGridProportions();

        Widgets.Add(mainGrid);
    }

    private void AddGridProportions()
    {
        for (int i = 0; i < 25; i++)
            mainGrid.RowsProportions.Add(WidthProportion);

        for (int i = 0; i < 50; i++)
            mainGrid.ColumnsProportions.Add(HeightProportion);
    }

    private Proportion WidthProportion => new Proportion()
    {
        Type = ProportionType.Pixels,
        Value = 20
    };

    private Proportion HeightProportion => new Proportion()
    {
        Type = ProportionType.Pixels,
        Value = 20
    };
}