using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Classes
{
    public class ConsolePrinter : Printer, IPrinter
    {
        public ConsolePrinter(ICard Card) : base(Card) { }

        public void Print()
        {
            
            Console.WriteLine("Your new card:");
            Console.WriteLine("______________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("{0,-20} {1}", "Cardtype:", Card.CardName);
            Console.WriteLine("{0,-20} {1}", "Holders name:", Card.HolderName);
            Console.WriteLine("{0,-20} {1}", "Card number:", Card.CardNumber);
            Console.WriteLine("{0,-20} {1}", "Reg. Number:", Card.RegNumber);
            Console.WriteLine("{0,-20} {1}", "Account number:", Card.AccountNumber);
            if (Card is IExpires)
            {
                Console.WriteLine("{0,-20} {1}", "Expiry date:", ((IExpires)Card).MaxExpireDate);

            }
            if (Card is ICreditCard)
            {
                Console.WriteLine("{0,-20} {1}", "Credit card:", "Yes");
                Console.WriteLine("{0,-20} {1}", "Credit max:", ((ICreditCard)Card).MaxCredit);
                Console.WriteLine("{0,-20} {1}", "Max withdraw:", ((ICreditCard)Card).MaxWithdrawPerDay);
            }
            Console.WriteLine();
            Console.WriteLine("______________________________________________________________________________");
        }
    }
}
