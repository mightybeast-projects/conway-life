using ConwayLife.Logic;
using Myra.Graphics2D.UI;

namespace ConwayLife.Desktop;

public class GenerationsLabel : Label
{
    private readonly Life life;

    public GenerationsLabel(Life life)
    {
        this.life = life;

        Text = "Generation : ";
        Font = LifeGame.fontSystem.GetFont(36);
    }
}