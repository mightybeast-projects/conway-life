using System;
using Microsoft.Xna.Framework;

namespace ConwayLife.Desktop;

public class Interval
{
    public bool isActive = true;

    private readonly Action Action;
    private readonly float interval;
    private int time;

    public Interval(Action action, int interval)
    {
        Action = action;
        this.interval = interval;
    }

    public void Update(GameTime gameTime)
    {
        if (!isActive)
            return;

        time += (int)gameTime.ElapsedGameTime.TotalMilliseconds;

        if (time >= interval)
        {
            Action();
            time = 0;
        }
    }
}