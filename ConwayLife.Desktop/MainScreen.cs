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

        VerticalStackPanel verticalStackPanel = new()
        {
            Spacing = 20,
            VerticalAlignment = VerticalAlignment.Center
        };

        verticalStackPanel.Widgets.Add(GenerationLabel);
        verticalStackPanel.Widgets.Add(GridPanel);
        verticalStackPanel.Widgets.Add(ButtonsPanel);

        lifeGame.desktop.Root = verticalStackPanel;
    }

    public override void Draw(GameTime gameTime)
    {

    }

    public override void Update(GameTime gameTime)
    {

    }

    private Label GenerationLabel => new()
    {
        Text = "Generation : 0",
        Font = LifeGame.fontSystem.GetFont(36),
        HorizontalAlignment = HorizontalAlignment.Center
    };

    private GridPanel GridPanel => new()
    {
        HorizontalAlignment = HorizontalAlignment.Center,
        VerticalAlignment = VerticalAlignment.Center
    };

    private ButtonsPanelWidget ButtonsPanel => new()
    {
        HorizontalAlignment = HorizontalAlignment.Center,
        VerticalAlignment = VerticalAlignment.Center
    };
}