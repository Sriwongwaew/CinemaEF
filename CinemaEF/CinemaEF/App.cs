using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaEf
{
    public class App
    {
        CinemaContext context = new CinemaContext();
        internal void Run()
        {
            MainMenu();

        }

        public void DisplayAllCinemas()
        {
            Console.WriteLine(" Våra Biografer:".ToUpper() + "\n");
            foreach (var item in context.Cinema.Select(x => x.Name))
            {
                Console.WriteLine(" " + item);
            }

        }




        private void MainMenu()
        {
            while (true)
            {
                Header("Välkommen till Filmstaden!");

                Console.WriteLine("\nVad vill du göra?\n");
                Console.WriteLine("1) Gå till huvudmenyn");
                Console.WriteLine("2) Visa alla biografer");
                Console.WriteLine("3) Visa alla filmer");
                Console.WriteLine("9) Stäng ner programmet");


                ConsoleKey command = Console.ReadKey().Key;
                Console.WriteLine();

                switch (command)
                {
                    case ConsoleKey.D1: MainMenu(); break;
                    case ConsoleKey.D2: DisplayAllCinemas(); break;
                    case ConsoleKey.D3: displayAllMovies(); break;
                    case ConsoleKey.D9: break;

                    default:
                        ErrorMessage("\nFelaktig input");
                        continue;
                }
                break;
            }
        }

        private void displayAllMovies()
        {
            Header("Alla filmer");
            foreach (var item in context.Movie)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Genre);
                Console.WriteLine(item.Description);
                Console.WriteLine("--------------------------");
                    
            }
        }

        private void Header(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text.ToUpper() + "\n");
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
