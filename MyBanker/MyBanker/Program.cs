using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBanker.Classes;

namespace MyBanker
{
    class Program
    {
        static void Main(string[] args)
        {
            bool createNewCard = false;
            do
            {
                Console.WriteLine("Print a Card:");
                Console.WriteLine();

                Console.Write("Write your name for the card:  ");
                string userInput = Console.ReadLine();
                IPrinter printer = Factory.NewPrinter(userInput);


                printer.Print();

                Console.WriteLine();
                Console.WriteLine("Done!");
                Console.WriteLine();

                Console.WriteLine("Create another? (y / n)");
                Console.WriteLine("Press (y / n)...");

                string userYesNo = Console.ReadLine();
                switch (userYesNo)
                {
                    case "y":
                        createNewCard = true;
                        break;
                    case "n":
                        createNewCard = false;
                        break;
                    default:
                        Console.WriteLine("Not a valid input");
                        Console.WriteLine("Exiting creator...");
                        Console.ReadKey();
                        break;
                }

            } while (createNewCard);

        }
    }
}
