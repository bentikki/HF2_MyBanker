using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Classes
{
    public class WithdrawCard : DebetCard, IWithdrawCard
    {
        public int MaxAge { get; private set; }

        public WithdrawCard(string HolderName) : base("Standard Withdraw card", HolderName, false, false, 13, 14, new string[] { "2400" })
        {
            this.MaxAge = 18;
        }

    }
}
