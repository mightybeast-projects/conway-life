using Myra.Graphics2D.UI;

namespace ConwayLife.Desktop;

public class ButtonsPanelWidget : VerticalStackPanel
{
    public ButtonsPanelWidget()
    {
        Spacing = 15;

        Widgets.Add(GenerationLabel);
        Widgets.Add(PlayButton);
        Widgets.Add(StepButton);
        Widgets.Add(ClearButton);
    }

    private Label GenerationLabel => new()
    {
        Text = "Generation : 0",
        Font = LifeGame.fontSystem.GetFont(36),
        HorizontalAlignment = HorizontalAlignment.Center
    };

    private GameButton PlayButton => new()
    {
        Text = "Play"
    };

    private GameButton StepButton => new()
    {
        Text = "Step"
    };

    private GameButton ClearButton => new()
    {
        Text = "Clear"
    };
}