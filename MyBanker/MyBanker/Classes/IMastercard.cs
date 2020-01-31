using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Classes
{
    interface IMastercard : ICreditCard, IMaxWithdraw
    {
    }
}
