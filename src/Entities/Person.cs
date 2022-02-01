namespace Rpg
{
    public abstract class Person
    {
        public int Life {get; set;}
        public int Mana {get; set;}
        public int Damage {get; set;}
        public abstract void PrintStatus();
    }
}