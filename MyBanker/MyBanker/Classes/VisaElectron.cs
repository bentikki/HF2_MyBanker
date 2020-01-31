using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Classes
{
    public class VisaElectron : DebetCard, IVisaElectron
    {
        public DateTime MaxExpireDate { get; private set; }
        public int MaxExpireLengthInDays { get; private set; }
        public double MaxWithdrawPerMonth { get; private set; }

        public VisaElectron( string HolderName) : base("Visa Electron", HolderName, true, true, 15, 12, new string[] { "4026", "41750", "4508", "4844", "4913", "4917" })
        {
            this.MaxExpireLengthInDays = 1826;
            this.CalculateExpireDate();
        }

        public void CalculateExpireDate()
        {
            this.MaxExpireDate = DateTime.Today;
            this.MaxExpireDate = MaxExpireDate.AddDays(this.MaxExpireLengthInDays);
        }
    }
}
