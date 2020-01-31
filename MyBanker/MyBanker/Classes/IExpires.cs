using System;

namespace MyBanker.Classes
{
    public interface IExpires
    {
        DateTime MaxExpireDate { get; }
        int MaxExpireLengthInDays { get; }

        void CalculateExpireDate();
    }
}