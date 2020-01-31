namespace MyBanker.Classes
{
    public interface ICreditCard : ICard, IExpires
    {
        double MaxCredit { get;  }
        double MaxWithdrawPerDay { get;  }
    }
}