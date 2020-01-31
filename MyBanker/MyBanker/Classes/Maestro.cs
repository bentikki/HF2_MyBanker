using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Classes
{
    class Maestro : DebetCard, IMaestro
    {
        public DateTime MaxExpireDate { get; private set; }
        public int MaxExpireLengthInDays { get; private set; }

        public Maestro(string HolderName) : base("Maestro Card", HolderName, true, true, 18, 15, new string[] { "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763" })
        {
            this.MaxExpireLengthInDays = 2069;
            this.CalculateExpireDate();
        }

        public void CalculateExpireDate()
        {
            this.MaxExpireDate = DateTime.Today;
            this.MaxExpireDate = MaxExpireDate.AddDays(this.MaxExpireLengthInDays);
        }
    }
}
