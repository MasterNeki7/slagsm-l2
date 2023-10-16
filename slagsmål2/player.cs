public class Player
{
    Random gen = new Random();

    public Weapon weapon = new();
    public int baseHp = 440;
    public int baseDmg = 35;
    public int baseCrit = 20;
    public string name;

    public int critChance;
    public int dmg;
    public int hp;

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