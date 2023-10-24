public class Enemy : Player
{
    Random gen = new Random();

    public List<String> Enemies = new List<String>() { "Yuriy Olegovic Garbachov Petrov IX", "Baltazar Octavius Bartholomew Jr", "Hector Mc Ewen Quintalius Carolus VI", "Robert Aurelius Cesie Cornelius XV" };

    public Enemy()
    {
        WeaponLocker locker = new();

        int[] baseHpAlts = { 440, 560, 740 };
        baseHp = baseHpAlts[gen.Next(baseHpAlts.Length)];
        baseDmg = 5;

        name = Enemies[gen.Next(Enemies.Count)];
        weapon = locker.GimmeRandom();
    }

    public void Attack()
    {

    }

    public void Defend()
    {

    }

}



