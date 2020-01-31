using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Classes
{
    public abstract class DebetCard : Card, IDebitCard
    {
        public DebetCard(string CardName, string HolderName, bool InternationalUse, bool OnlineUse, int MinAge, int CardNumberLength, string[] CardNumberPrefix) : base(CardName, HolderName, InternationalUse, OnlineUse, MinAge, CardNumberLength, CardNumberPrefix)
        {

        }
    }
}
