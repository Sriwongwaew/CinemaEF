using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaEf
{
    public class App
    {
        internal void Run()
        {
            MainMenu();
        }

        private void MainMenu()
        {
            while (true)
            {
                Header("Välkommen till Rigoletto!");

                Console.WriteLine("\nVad vill du göra?\n");
                Console.WriteLine("A) Gå till huvudmenyn");


                ConsoleKey command = Console.ReadKey().Key;
                Console.WriteLine();

                switch (command)
                {
                    case ConsoleKey.A: MainMenu(); break;

                    case ConsoleKey.Q: break;

                    default:
                        ErrorMessage("\nFelaktig input");
                        continue;
                }
                break;
            }
        }

        private void Header(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
            
        }

        private void ErrorMessage(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
