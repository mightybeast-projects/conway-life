using System;
using ConwayLife.Logic;
using Microsoft.Xna.Framework;

namespace ConwayLife.Desktop;

public class DeadCell : GridCell
{
    protected override Color textureColor => Color.Black;

    protected override Action onClick => () => life.SpawnCell(cell.i, cell.j);

    public DeadCell(Life life, Cell cell) : base(life, cell) { }
}