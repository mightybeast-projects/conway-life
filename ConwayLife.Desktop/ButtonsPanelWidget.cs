using ConwayLife.Logic;
using Myra.Graphics2D.UI;

namespace ConwayLife.Desktop;

public class ButtonsPanelWidget : HorizontalStackPanel
{
    private readonly Life life;

    public ButtonsPanelWidget(Life life)
    {
        this.life = life;

        Spacing = 15;

        Widgets.Add(PlayButton);
        Widgets.Add(StepButton);
        Widgets.Add(ClearButton);
    }

    private GameButton PlayButton => new()
    {
        Text = "Play"
    };

    private GameButton StepButton => new(life.Mutate)
    {
        Text = "Step"
    };

    private GameButton ClearButton => new(life.ClearGrid)
    {
        Text = "Clear"
    };
}