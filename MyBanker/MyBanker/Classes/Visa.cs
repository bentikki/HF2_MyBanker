using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Classes
{
    class Visa : CreditCard, IVisa
    {
        public Visa(string HolderName) : base("Visa", HolderName, true, true, 18, 20000, 1826, 25000, 15, new string[] { "4" })
        {

        }

    }
}
