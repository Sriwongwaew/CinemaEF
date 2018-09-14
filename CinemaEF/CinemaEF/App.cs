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
                Header("Välkommen till Filmstaden!");

                Console.WriteLine("\nVad vill du göra?\n");
                Console.WriteLine("1) Gå till huvudmenyn");
                Console.WriteLine("2) Login");
                Console.WriteLine("9) Stäng ner programmet");


                ConsoleKey command = Console.ReadKey().Key;
                Console.WriteLine();

                switch (command)
                {
                    case ConsoleKey.D1: MainMenu(); break;
                    case ConsoleKey.D2: Login(); break;
                    case ConsoleKey.D9: break;

                    default:
                        ErrorMessage("\nFelaktig input\n");
                        continue;
                }
                break;
            }
        }

        private void Login()
        {
            Console.WriteLine("Skriv in din mejladress: ");
            string memberMail = Console.ReadLine();
            Console.WriteLine("Skriv in ditt lösenord: ");

            string password = HideCharacter();

            Customer customer = AppAdd.LoginToDatabase(memberMail, password);

            if (customer == null)
            {
                ErrorMessage("\nFelaktig input");
                Login();
            }

            else
            {
                Header("\nVälkommen " + customer.Name + "\n");

                while (true)
                {
                    Console.WriteLine("\nVad vill du göra?\n");
                    Console.WriteLine("1) Gå tillbaka till huvudmenyn");
                    Console.WriteLine("2) Se tillgängliga filmer");
                    Console.WriteLine("3) Köpa/reservera biljett");

                    ConsoleKey command = Console.ReadKey().Key;
                    Console.WriteLine();

                    switch (command)
                    {
                        case ConsoleKey.D1: MainMenu(); break;
                        //case ConsoleKey.D2: WatchAvailableMovies(); break;
                        //case ConsoleKey.D3: BuyAndReserveTicket(); break;

                        default:
                            ErrorMessage("\nFelaktig input");
                            continue;
                    }
                    break;
                }
            }
            
        }

        private string HideCharacter()
        {
            ConsoleKeyInfo key;
            string code = "";
            do
            {
                key = Console.ReadKey(true);

                if (Char.IsNumber(key.KeyChar))
                {
                    Console.Write("*");
                    code += key.KeyChar;
                }

            } while (key.Key != ConsoleKey.Enter);

            return code;
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
