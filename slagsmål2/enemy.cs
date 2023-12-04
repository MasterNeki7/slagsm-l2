public class Scav : Player
{
    Random gen = new Random();

    public List<String> Enemies = new List<String>() { "Yuriy Olegovic Gorbachov Petrov IX", "Baltazar Octavius Bartholomew Jr", "Hector Mc Ewen Quintalius Carolus VI", "Robert Aurelius Cesie Cornelius XV", "Oliver" };

    public Scav()
    {
        WeaponLocker locker = new();

        int[] baseHpAlts = { 440, 560, 740 };
        baseHp = baseHpAlts[gen.Next(baseHpAlts.Length)];

        name = Enemies[gen.Next(Enemies.Count)];
        weapon = locker.WeaponRandom();
    }

    public void Attack()
    {

    }

    public void Defend()
    {

    }

}



