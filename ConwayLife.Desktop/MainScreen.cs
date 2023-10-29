using ConwayLife.Logic;
using Microsoft.Xna.Framework;
using MonoGame.Extended.Screens;
using Myra.Graphics2D.UI;

namespace ConwayLife.Desktop;

public class MainScreen : GameScreen
{
    public const int gridWidth = 50;
    public const int gridHeight = 25;

    private readonly LifeGame lifeGame;
    private readonly Life life;
    private readonly Interval lifeMutationInterval;

    public MainScreen(LifeGame lifeGame) : base(lifeGame)
    {
        this.lifeGame = lifeGame;
        life = new Life(gridWidth, gridHeight);
        lifeMutationInterval = new Interval(life.Mutate, 100);
    }

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

    public override void Draw(GameTime gameTime) { }

    public override void Update(GameTime gameTime) =>
        lifeMutationInterval.Update(gameTime);

    private GenerationsLabel GenerationLabel => new(life)
    {
        HorizontalAlignment = HorizontalAlignment.Center
    };

    private LifeGrid GridPanel => new(life)
    {
        HorizontalAlignment = HorizontalAlignment.Center,
        VerticalAlignment = VerticalAlignment.Center
    };

    private ButtonsPanelWidget ButtonsPanel => new(life, lifeMutationInterval)
    {
        HorizontalAlignment = HorizontalAlignment.Center,
        VerticalAlignment = VerticalAlignment.Center
    };
}