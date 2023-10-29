using Myra.Graphics2D.UI;

namespace ConwayLife.Desktop;

public class ButtonsPanelWidget : HorizontalStackPanel
{
    public ButtonsPanelWidget()
    {
        Spacing = 15;

        Widgets.Add(PlayButton);
        Widgets.Add(StepButton);
        Widgets.Add(ClearButton);
    }

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