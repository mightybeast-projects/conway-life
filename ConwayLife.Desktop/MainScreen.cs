using Microsoft.Xna.Framework;
using MonoGame.Extended.Screens;
using Myra.Graphics2D.UI;

namespace ConwayLife.Desktop;

public class MainScreen : GameScreen
{
    private readonly LifeGame lifeGame;

    public MainScreen(LifeGame lifeGame) : base(lifeGame) =>
        this.lifeGame = lifeGame;

    public override void LoadContent()
    {
        base.LoadContent();

        lifeGame.desktop.Root = new Label()
        {
            Text = "Hello",
            Font = LifeGame.fontSystem.GetFont(24)
        };
    }

    public override void Draw(GameTime gameTime)
    {

    }

    public override void Update(GameTime gameTime)
    {

    }
}