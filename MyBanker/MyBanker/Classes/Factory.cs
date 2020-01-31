using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Classes
{
    public static class Factory
    {
        public static IPrinter NewPrinter(string holderName)
        {
            //Can be FilePrinter to print to file.
            return new ConsolePrinter(NewCard(holderName));
        }
        public static ICard NewCard(string holderName)
        {
            //Sets the card to be printet.
            return new Visa(holderName);
        }
    }
}
