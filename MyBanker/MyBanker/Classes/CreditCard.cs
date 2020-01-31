using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Classes
{
    abstract class CreditCard : Card, ICreditCard
    {
        public CreditCard(string CardName, string HolderName, bool InternationalUse, bool OnlineUse, int MinAge, double MaxCredit, int MaxExpireLengthInDays, double MaxWithdrawPerDay, int CardNumberLength, string[] CardNumberPrefix) : base(CardName, HolderName, InternationalUse, OnlineUse, MinAge, CardNumberLength, CardNumberPrefix)
        {
            this.MaxCredit = MaxCredit;
            this.MaxExpireLengthInDays = MaxExpireLengthInDays;
            this.MaxWithdrawPerDay = MaxWithdrawPerDay;
            CalculateExpireDate();
        }

        public double MaxCredit { get; private set; }
        public DateTime MaxExpireDate { get; private set; }
        public int MaxExpireLengthInDays { get; private set; }
        public double MaxWithdrawPerDay { get; private set; }

        public void CalculateExpireDate()
        {
            //Calculate expire date. Set MaxExpireDate to = Today + MaxExpireLengthInDays.
            this.MaxExpireDate = DateTime.Today;
            this.MaxExpireDate = MaxExpireDate.AddDays(this.MaxExpireLengthInDays);
        }
    }
}
