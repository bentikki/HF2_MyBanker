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


            do
            {
                Console.WriteLine("______________________________________________________________________________");
                Console.WriteLine();

                ICard[] cardList =
                {
                    Factory.NewWithdrawCard("Ordinary withdraw card holder"),
                    Factory.NewMaestro("Maestro card holder"),
                    Factory.NewVisaElectron("Visa Electron Holder"),
                    Factory.NewVisa("Visa Card holder"),
                    Factory.NewMastercard("Mastercard Holder")
                };

                Console.WriteLine("Randomly generated cards:");
                Console.WriteLine();
                foreach (ICard card in cardList)
                {
                    Console.WriteLine($"Cardtype: { card.CardName }");
                    Console.WriteLine($"Holders name: { card.HolderName }");
                    Console.WriteLine($"Card number: { card.CardNumber}");
                    Console.WriteLine($"Reg. Number: { card.RegNumber}");
                    Console.WriteLine($"Account number: { card.AccountNumber}");
                    if (card is IExpires)
                    {
                        Console.WriteLine($"Expiry date: { ((IExpires)card).MaxExpireDate }");
                    }
                    if (card is ICreditCard)
                    {
                        Console.WriteLine("Credit card: Yes");
                        Console.WriteLine($"Credit max: { ((ICreditCard)card).MaxCredit}");
                        Console.WriteLine($"Max withdraw per month: { ((ICreditCard)card).MaxWithdrawPerDay}");
                    }
                    Console.WriteLine();

                }
                Console.WriteLine("______________________________________________________________________________");
                Console.WriteLine();
                Console.WriteLine("Generate new cards (Press any key...)");
                Console.ReadKey();

            } while (true);

            

            

        }
    }
}
