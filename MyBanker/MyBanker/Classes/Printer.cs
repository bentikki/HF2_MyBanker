using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Classes
{
    public abstract class Printer
    {
        public ICard Card { get; private set; }

        public Printer(ICard Card)
        {
            this.Card = Card;
        }
    }
}
