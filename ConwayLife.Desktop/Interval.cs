using System;
using Microsoft.Xna.Framework;

namespace ConwayLife.Desktop;

public class Interval
{
    public bool isActive;

    private readonly Action Action;
    private readonly float interval;
    private int time;

    public Interval(Action action, int interval)
    {
        Action = action;
        this.interval = interval;
    }

    public void Start() => isActive = true;

    public void Stop() => isActive = false;

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