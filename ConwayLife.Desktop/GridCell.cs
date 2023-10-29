using System;
using ConwayLife.Logic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Myra;
using Myra.Graphics2D.TextureAtlases;
using Myra.Graphics2D.UI;

namespace ConwayLife.Desktop;

public abstract class GridCell : ImageButton
{
    protected abstract Color textureColor { get; }
    protected abstract Action onClick { get; }
    protected Life life;
    protected Cell cell;

    private const int size = 18;

    public GridCell(Life life, Cell cell)
    {
        this.life = life;
        this.cell = cell;

        GridRow = life.grid.height - 1 - cell.j;
        GridColumn = cell.i;

        Texture2D texture = new Texture2D(MyraEnvironment.GraphicsDevice, 1, 1);
        texture.SetData(new[] { textureColor });

        Image = new TextureRegion(texture, new Rectangle(0, 0, size, size));

        VerticalAlignment = VerticalAlignment.Center;
        HorizontalAlignment = HorizontalAlignment.Center;

        TouchUp += (s, a) => onClick.Invoke();
    }
}