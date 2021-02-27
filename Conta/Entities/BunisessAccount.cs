

namespace Conta.Entities
{
    class BunisessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BunisessAccount()
        {

        }

        public BunisessAccount(int number, string holder, double balance, double loanlimit) : base (number, holder, balance)
        {
            LoanLimit = loanlimit;

        }

        public void Loan ( double amount)
        {
            if (amount <= LoanLimit)
            { Balance += amount; }
        }
    }
}
