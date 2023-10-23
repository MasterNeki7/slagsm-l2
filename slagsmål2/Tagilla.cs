public class Tagilla : Enemy
{

    Random gen = new Random();

    public Weapon weapon = new();
    public int baseHp = 1220;
    public int baseDmg = 125;

    public int dmg;
    public int hp;

    public Tagilla()
    {
        name = "Tagilla";
        // weapon = new Weapon() { name = "Sledgehammer" };
    }

    public void Attack()
    {

    }

    public void Defend()
    {

    }

}