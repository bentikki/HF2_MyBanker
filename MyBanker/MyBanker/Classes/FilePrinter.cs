using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Classes
{
    public class FilePrinter : Printer, IPrinter
    {
        public FilePrinter(ICard Card) : base(Card) { }

        public void Print()
        {
            string cardName = $"{Card.CardName}_for_{Card.HolderName}_with_Cardnumber_{Card.CardNumber}"; 
            string path = @"c:\temp\"+ cardName + ".txt";

            //File.Create(path);
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine("Your new card:");
            writer.WriteLine("______________________________________________________________________________");
            writer.WriteLine();
            writer.WriteLine("{0,-20} {1}", "Cardtype:", Card.CardName);
            writer.WriteLine("{0,-20} {1}", "Holders name:", Card.HolderName);
            writer.WriteLine("{0,-20} {1}", "Card number:", Card.CardNumber);
            writer.WriteLine("{0,-20} {1}", "Reg. Number:", Card.RegNumber);
            writer.WriteLine("{0,-20} {1}", "Account number:", Card.AccountNumber);
            if (Card is IExpires)
            {
                writer.WriteLine("{0,-20} {1}", "Expiry date:", ((IExpires)Card).MaxExpireDate);

            }
            if (Card is ICreditCard)
            {
                writer.WriteLine("{0,-20} {1}", "Credit card:", "Yes");
                writer.WriteLine("{0,-20} {1}", "Credit max:", ((ICreditCard)Card).MaxCredit);
                writer.WriteLine("{0,-20} {1}", "Max withdraw:", ((ICreditCard)Card).MaxWithdrawPerDay);
            }
            writer.WriteLine();
            writer.WriteLine("______________________________________________________________________________");

            writer.Close();

        }
    }
}
