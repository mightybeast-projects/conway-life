using ConwayLife.Logic;
using Myra.Graphics2D.UI;

namespace ConwayLife.Desktop;

public class GenerationsLabel : Label, ILifeObserver
{
    private readonly Life life;

    public GenerationsLabel(Life life)
    {
        this.life = life;
        life.Subscribe(this);

        Font = LifeGame.fontSystem.GetFont(36);

        UpdateText();
    }

    public void Notify() => UpdateText();

    private void UpdateText() => Text = "Generation : " + life.generation;
}