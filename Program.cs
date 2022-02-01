using static System.Console;
using Rpg;
public class Program
{
    static void Main()
    {
        Battle battle = new Battle();
        Warrior warrior = new Warrior(200,150,15);
        Wizzard wizzard = new Wizzard(150,200,25);

        battle.StartBattle(wizzard, warrior);


    }
}