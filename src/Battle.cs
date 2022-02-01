using static System.Console;
using System.IO;
using System;

namespace Rpg
{
    public class Battle
    {
        private int choice;
        private int rounds = 0;
        public Battle() 
        { }

        public void ShowMenu()
        {
            WriteLine("Menu Principal: [1] Iniciar, [2] Sair");
        }

        public void StartBattle(Wizzard wi, Warrior wa)
        {
            ShowMenu();
            choice = Int32.Parse(ReadLine());

            if(choice == 1)
            {
                

                while(true)
                {
                    Clear();
                    WriteLine($"Round = {rounds}");

                    wa.PrintStatus();
                    wi.PrintStatus();

                    wa.AutoAtack(wi);
                    wi.AutoAtack(wa);
                        
                    if(wa.Life <= 0)
                    {
                        WriteLine("O mago é implacável");
                        break;
                    }
                    else if( wi.Life <= 0)
                    {
                        WriteLine("Leroooi");
                        break;
                    }
                }
                
                    
                }
                else if(choice == 2)
                {   
                    WriteLine("Programa encerrado");
                      
                }
                else
                {   
                    Clear();
                    WriteLine("Escolha um número entre 1 e 2");

                    ShowMenu();
                    choice = Int32.Parse(ReadLine());
                
                }

            

        }
    }
}