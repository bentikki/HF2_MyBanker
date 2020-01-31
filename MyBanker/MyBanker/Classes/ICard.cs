namespace MyBanker.Classes
{
    public interface ICard
    {
        string CardName { get;  }
        bool InternationalUse { get;  }
        bool OnlineUse { get;  }
        string CardNumber { get;  }
        string[] CardNumberPrefix { get; }
        int CardNumberLength { get; }
        string RegNumber { get;  }
        string AccountNumber { get;  }
        string HolderName { get;  }
        int MinAge { get;  }
        void CalculateCardNumber(int length);
    }
}