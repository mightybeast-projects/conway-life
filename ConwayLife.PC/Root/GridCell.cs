using System;
using ConwayLife.Logic.Main;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Myra;
using Myra.Graphics2D.TextureAtlases;
using Myra.Graphics2D.UI;

namespace ConwayLife.PC.Root;

public class GridCell : ImageButton, ICellObserver
{
    private const int size = 18;
    private Color textureColor;
    private Action onClick;
    private Life life;
    private Cell cell;

    public GridCell(Life life, Cell cell)
    {
        this.life = life;
        this.cell = cell;

        cell.Subscribe(this);

        GridRow = life.grid.height - 1 - cell.j;
        GridColumn = cell.i;

        VerticalAlignment = VerticalAlignment.Center;
        HorizontalAlignment = HorizontalAlignment.Center;

        Update();

        TouchUp += (s, a) => onClick.Invoke();
    }

    public void Notify() => Update();

    private void Update()
    {
        if (cell.isAlive)
        {
            textureColor = Color.DarkOrange;
            onClick = () => life.KillCell(cell.i, cell.j);
        }
        else
        {
            textureColor = Color.Black;
            onClick = () => life.SpawnCell(cell.i, cell.j);
        }

        Texture2D texture = new(MyraEnvironment.GraphicsDevice, 1, 1);
        texture.SetData(new[] { textureColor });

        Image = new TextureRegion(texture, new Rectangle(0, 0, size, size));
    }
}