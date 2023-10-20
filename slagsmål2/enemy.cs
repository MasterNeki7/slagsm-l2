public class Enemy : Player
{
    Random gen = new Random();

    public List<String> Enemies = new List<String>() { "Yuriy Olegovic Garbachov Petrov IX", "Baltazar Octavius Bartholomew Jr", "Hector Mc Ewen Quintalius Carolus VI", "Robert Aurelius Cesie Cornelius XV" };

    public Enemy()
    {
        int[] baseHpAlts = { 440, 560, 740 };
        baseHp = baseHpAlts[gen.Next(baseHpAlts.Length)];
        baseDmg = 5;

        name = Enemies[gen.Next(Enemies.Count)];
        weapon = new Weapon() { name = weapon.Weapons[gen.Next(weapon.Weapons.Count)] };
    }

    public void Attack()
    {

    }

    public void Defend()
    {

    }

}



