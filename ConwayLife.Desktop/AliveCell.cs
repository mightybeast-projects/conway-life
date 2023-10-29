using System;
using ConwayLife.Logic;
using Microsoft.Xna.Framework;

namespace ConwayLife.Desktop;

public class AliveCell : GridCell
{
    protected override Color textureColor => Color.DarkOrange;

    protected override Action onClick => () => life.KillCell(cell.i, cell.j);

    public AliveCell(Life life, Cell cell) : base(life, cell) { }
}