using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Classes
{
    //Main Card object. Holds card information for all types of cards. 
    public abstract class Card : ICard
    {
        public string CardName { get; private set; }
        public string HolderName { get; private set; }
        public string RegNumber { get; private set; }
        public string AccountNumber { get; private set;}
        public string CardNumber { get; private set; }
        public string[] CardNumberPrefix { get; private set; }
        public bool InternationalUse { get; private set; }
        public bool OnlineUse { get; private set; }
        public int MinAge { get; private set; }
        public int CardNumberLength { get; private set; }

        public Card(string CardName, string HolderName, bool InternationalUse, bool OnlineUse, int MinAge, int CardNumberLength, string[] CardNumberPrefix)
        {
            this.CardName = CardName;
            this.HolderName = HolderName;
            this.RegNumber = RegNumber;
            this.AccountNumber = AccountNumber;
            this.CardNumber = CardNumber;
            this.InternationalUse = InternationalUse;
            this.OnlineUse = OnlineUse;
            this.MinAge = MinAge;
            this.CardNumberLength = CardNumberLength;
            this.CardNumberPrefix = CardNumberPrefix;
            CalculateCardNumber(CardNumberLength);
            this.AccountNumber = RandomNumbers(14);
            this.RegNumber = "3520";
        }

        public void CalculateCardNumber(int length)
        {
            int randomKey = new Random().Next(0, (CardNumberPrefix.Length - 1));
            CardNumber = CardNumberPrefix[randomKey] + RandomNumbers(length);
        }

        private string RandomNumbers(int length)
        {
            const string pool = "0123456789";
            var builder = new StringBuilder();
            Random random = new Random();
            for (var i = 0; i < length; i++)
            {
                var c = pool[random.Next(0, pool.Length)];
                builder.Append(c);
            }
            return builder.ToString();
        }

    }
}
