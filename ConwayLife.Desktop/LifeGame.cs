using Microsoft.Xna.Framework;
using MonoGame.Extended.Screens;
namespace ConwayLife.Desktop;

public class LifeGame : Game
{
    private readonly ScreenManager screenManager;

    public LifeGame()
    {
        GraphicsDeviceManager graphics = new(this);
        screenManager = new();
        Content.RootDirectory = "Content";
        IsMouseVisible = true;

        Components.Add(screenManager);

        graphics.PreferredBackBufferWidth = 1280;
        graphics.PreferredBackBufferHeight = 720;
    }

    protected override void Initialize() => base.Initialize();

    protected override void LoadContent() =>
        screenManager.LoadScreen(new MainScreen(this));
}
