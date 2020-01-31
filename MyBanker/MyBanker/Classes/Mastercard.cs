using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Classes
{
    class Mastercard : CreditCard, IMastercard
    {
        public double MaxWithdrawPerMonth { get; private set; }

        public Mastercard(string HolderName) : base("Mastercard", HolderName, true, true, 18, 40000, 1826, 30000, 14, new string[] { "51", "52", "53", "54", "55" })
        {
            this.MaxWithdrawPerMonth = 30000;
        }

    }
}
