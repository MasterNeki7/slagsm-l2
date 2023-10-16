public class Enemy
{
    Random gen = new Random();

    public Weapon weapon = new();
    public int baseHp = 100;
    public int baseDmg = 5;
    public int baseCrit = 5;
    public string name;

    public int critChance;
    public int dmg;
    public int hp;

        public List<String> Enemies = new List<String>() { "Yuriy Olegovic Garbachov Petrov IX", "Baltazar Octavius Bartholomew Jr", "Hector Mc Ewen Quintalius Carolus VI", "Robert Aurelius Cesie Cornelius XV" };

        public Enemy()
        {
            name = Enemies[gen.Next(Enemies.Count)];
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



