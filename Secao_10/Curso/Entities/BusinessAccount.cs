namespace Curso.Entities
{
    class BuninessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BuninessAccount() { }

        public BuninessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount < LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}