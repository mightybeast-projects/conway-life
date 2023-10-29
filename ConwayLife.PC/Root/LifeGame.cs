using System.IO;
using FontStashSharp;
using Microsoft.Xna.Framework;
using MonoGame.Extended.Screens;
using Myra;
using Myra.Graphics2D.UI;

namespace ConwayLife.PC.Root;

public class LifeGame : Game
{
    public static FontSystem fontSystem;

    public Desktop desktop;

    private const string contentPath = "Content";
    private const string fontPath = "Content/Font/Tektur.ttf";

    private readonly ScreenManager screenManager;

    public LifeGame()
    {
        GraphicsDeviceManager graphics = new(this);
        fontSystem = new FontSystem();
        screenManager = new();

        Components.Add(screenManager);

        graphics.PreferredBackBufferWidth = 1280;
        graphics.PreferredBackBufferHeight = 720;

        MyraEnvironment.Game = this;
        Content.RootDirectory = contentPath;
        IsMouseVisible = true;
    }

    protected override void LoadContent()
    {
        desktop = new();

        byte[] ttfData = File.ReadAllBytes(fontPath);
        fontSystem.AddFont(ttfData);

        screenManager.LoadScreen(new MainScreen(this));
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Black);
        desktop.Render();
    }
}
