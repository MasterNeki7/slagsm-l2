public class Fighter
{
    Random gen = new Random();

    List<String> Fighters = new List<String>() { "Yuriy Olegovic Garbachov Petrov XII", "Baltazar", "Hector" };

    public Weapon weapon;
    public int baseHp;
    public int baseDmg;
    public int baseCrit;
    public string name;

    public Fighter()
    {
        name = "";
        weapon = new Weapon() { name = "" };
    }

    public void Attack()
    {

    }

    public void Defend()
    {

    }

    public void CritChance()
    {

    }

}



