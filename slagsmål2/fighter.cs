public class Fighter
{
    Random gen = new Random();

    public List<String> Fighters = new List<String>() { "Yuriy Olegovic Garbachov Petrov XII", "Baltazar", "Hector" };

    public Weapon weapon = new();
    public int baseHp;
    public int baseDmg;
    public int baseCrit;
    public string name;

    public Fighter()
    {
        name = Fighters[gen.Next(Fighters.Count)];
        weapon = new Weapon() {name = weapon.Weapons[gen.Next(weapon.Weapons.Count)]};
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



