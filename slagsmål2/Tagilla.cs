public class Tagilla : Enemy
{

    Random gen = new Random();

    public Weapon weapon = new();
    public int baseHp = 1220;
    public int baseDmg = 116;
    public int baseCrit = 50;
    public string name;

    public int critChance;
    public int dmg;
    public int hp;

        public Tagilla()
        {
            name = "Tagilla";
            weapon = new Weapon() { name = "Sledgehammer" };
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