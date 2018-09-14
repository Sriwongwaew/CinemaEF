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
<<<<<<< HEAD
        internal void Run()
        {
            MainMenu();
            DisplayAllCinemas();
=======

        internal void Run()
        {
           // MainMenu();
            DisplayAllCinemas();
        }

        private void DisplayAllCinemas()
        {
            Console.WriteLine(" Våra Biografer:".ToUpper()+ "\n");
            foreach (var item in context.Cinema.Select(x => x.Name))
            {
                Console.WriteLine(" " + item);
            }
            
>>>>>>> FeliciasAddApp
        }


        private void DisplayAllCinemas()
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
                Console.WriteLine("9) Stäng ner programmet");


                ConsoleKey command = Console.ReadKey().Key;
                Console.WriteLine();

                switch (command)
                {
                    case ConsoleKey.D1: MainMenu(); break;
                    case ConsoleKey.D9: break;

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
