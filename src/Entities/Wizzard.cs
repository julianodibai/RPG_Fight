namespace Rpg
{
    public class Wizzard : Person
    {
        public Wizzard(int life , int mana, int damage)
        { 
            Life = life;
            Mana = mana;
            Damage = damage;
        }

        public int AutoAtack(Warrior wa)
        {
            Console.WriteLine("O wizzard causou 25 de dano");
            return wa.Life -= Damage;
        }

        public override void PrintStatus()
        {
            Console.WriteLine("Wizzard Status");
            Console.WriteLine($"Life : {Life}");
           // Console.WriteLine($"Mana : {Mana}");
            
        }
    }
}