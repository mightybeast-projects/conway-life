using ConwayLife.Logic.Main;

namespace ConwayLife.PC.Root;

public class PatternSpawner
{
    private readonly Life life;

    public PatternSpawner(Life life) => this.life = life;

    public void SpawnStarterPatterns()
    {
        SpawnBlock();
        SpawnBeeHive();
        SpawnTub();
        SpawnBlinker();
        SpawnToad();
        SpawnGlider();
        SpawnPentaDecathlon();
    }

    private void SpawnBlock()
    {
        life.SpawnCell(45, 10);
        life.SpawnCell(45, 11);
        life.SpawnCell(46, 10);
        life.SpawnCell(46, 11);
    }

    private void SpawnBeeHive()
    {
        life.SpawnCell(43, 5);

        life.SpawnCell(44, 4);
        life.SpawnCell(45, 4);

        life.SpawnCell(46, 5);

        life.SpawnCell(44, 6);
        life.SpawnCell(45, 6);
    }

    private void SpawnTub()
    {
        life.SpawnCell(0, 1);
        life.SpawnCell(1, 0);
        life.SpawnCell(1, 2);
        life.SpawnCell(2, 1);
    }

    private void SpawnBlinker()
    {
        life.SpawnCell(45, 18);
        life.SpawnCell(46, 18);
        life.SpawnCell(47, 18);
    }

    private void SpawnToad()
    {
        life.SpawnCell(5, 5);
        life.SpawnCell(6, 5);
        life.SpawnCell(7, 5);

        life.SpawnCell(6, 6);
        life.SpawnCell(7, 6);
        life.SpawnCell(8, 6);
    }

    private void SpawnGlider()
    {
        life.SpawnCell(12, 21);
        life.SpawnCell(13, 21);
        life.SpawnCell(14, 21);

        life.SpawnCell(14, 22);
        life.SpawnCell(13, 23);
    }

    private void SpawnPentaDecathlon()
    {
        life.SpawnCell(23, 6);
        life.SpawnCell(24, 6);
        life.SpawnCell(25, 6);

        life.SpawnCell(24, 7);
        life.SpawnCell(24, 8);

        life.SpawnCell(23, 9);
        life.SpawnCell(24, 9);
        life.SpawnCell(25, 9);

        life.SpawnCell(23, 11);
        life.SpawnCell(24, 11);
        life.SpawnCell(25, 11);

        life.SpawnCell(23, 12);
        life.SpawnCell(24, 12);
        life.SpawnCell(25, 12);

        life.SpawnCell(23, 14);
        life.SpawnCell(24, 14);
        life.SpawnCell(25, 14);

        life.SpawnCell(24, 15);
        life.SpawnCell(24, 16);

        life.SpawnCell(23, 17);
        life.SpawnCell(24, 17);
        life.SpawnCell(25, 17);
    }
}