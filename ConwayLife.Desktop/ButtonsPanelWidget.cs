using ConwayLife.Logic;
using Myra.Graphics2D.UI;

namespace ConwayLife.Desktop;

public class ButtonsPanelWidget : HorizontalStackPanel
{
    private readonly Life life;
    private readonly Interval lifeMutationInterval;

    public ButtonsPanelWidget(Life life, Interval lifeMutationInterval)
    {
        this.life = life;
        this.lifeMutationInterval = lifeMutationInterval;

        Spacing = 15;

        Widgets.Add(PlayButton);
        Widgets.Add(StopButton);
        Widgets.Add(StepButton);
        Widgets.Add(ClearButton);
    }

    private GameButton PlayButton => new(lifeMutationInterval.Start)
    {
        Text = "Play"
    };

    private GameButton StopButton => new(lifeMutationInterval.Stop)
    {
        Text = "Stop"
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