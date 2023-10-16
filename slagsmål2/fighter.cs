public class Fighter
{
    Random gen = new Random();

    public List<String> Fighters = new List<String>() { "Yuriy Olegovic Garbachov Petrov XII", "Baltazar", "Hector" };

    public Weapon weapon = new();
    public int baseHp = 100;
    public int baseDmg = 5;
    public int baseCrit = 5;
    public string name;

    public int critChance;
    public int dmg;

    public Fighter()
    {
        name = Fighters[gen.Next(Fighters.Count)];
        weapon = new Weapon() {name = weapon.Weapons[gen.Next(weapon.Weapons.Count)]};
    }

    public void Attack()
    {
        

        CritChance();
    }

    public void Defend()
    {

    }

    public void CritChance()
    {
        critChance = gen.Next(30);
        if(critChance < baseCrit)
        {
            dmg = dmg * 2;
        }
    }

}



