using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Classes
{
    public static class Factory
    {
        public static ICard NewVisaElectron(string holderName)
        {
            return new VisaElectron(holderName);
        }
        public static ICard NewVisa(string holderName)
        {
            return new Visa(holderName);
        }
        public static ICard NewMastercard(string holderName)
        {
            return new Mastercard(holderName);
        }
        public static ICard NewMaestro(string holderName)
        {
            return new Maestro(holderName);
        }
        public static ICard NewWithdrawCard(string holderName)
        {
            return new WithdrawCard(holderName);
        }
    }
}
