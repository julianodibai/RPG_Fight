namespace Rpg
{
    public class Warrior : Person
    {
        public Warrior(int life , int mana, int damage) 
        {
            Life = life;
            Mana = mana;
            Damage = damage;
        }

        public int AutoAtack(Wizzard wi)
        {
            Console.WriteLine("O warrior causou 15 de dano");
            return wi.Life -= Damage;
        }

        public override void PrintStatus()
        {
            Console.WriteLine("Warrior Status");
            Console.WriteLine($"Life : {Life}");
            //Console.WriteLine($"Mana : {Mana}");
        }

    }
}