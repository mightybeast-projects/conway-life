using System;
using Microsoft.Xna.Framework;
using Myra.Graphics2D.Brushes;
using Myra.Graphics2D.UI;

namespace ConwayLife.PC.Root;

public class GameButton : TextButton
{
    public GameButton(Action onClick = null)
    {
        HorizontalAlignment = HorizontalAlignment.Center;
        Background = new SolidBrush(Color.Black);
        Font = LifeGame.fontSystem.GetFont(24);
        Border = new SolidBrush(Color.DarkOrange);
        BorderThickness = new(2);
        PressedBackground = new SolidBrush(Color.Green);
        Padding = new(5, 0);

        TouchUp += (s, a) => onClick?.Invoke();
    }
}