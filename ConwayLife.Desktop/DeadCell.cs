using ConwayLife.Logic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Myra;
using Myra.Graphics2D.TextureAtlases;
using Myra.Graphics2D.UI;

namespace ConwayLife.Desktop;

public class DeadCell : ImageButton
{
    public DeadCell(Life life, Cell cell)
    {
        GridRow = life.grid.height - 1 - cell.j;
        GridColumn = cell.i;

        Texture2D texture = new Texture2D(MyraEnvironment.GraphicsDevice, 1, 1);
        texture.SetData(new[] { Color.Black });

        Image = new TextureRegion(texture, new Rectangle(0, 0, 18, 18));

        VerticalAlignment = VerticalAlignment.Center;
        HorizontalAlignment = HorizontalAlignment.Center;

        TouchUp += (s, a) => life.SpawnCell(cell.i, cell.j);
    }
}