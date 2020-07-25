using SaqueContaBancariaComExcecao.Entities.Exceptions;

namespace SaqueContaBancariaComExcecao.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Withdraw(double amount)
        {
            if(amount > WithdrawLimit)
            {
                throw new DomainExceptions("Withdraw error: The amount exceeds withdraw limit.");
            }
            else if (amount > Balance)
            {
                throw new DomainExceptions("Withdraw error: Not enough balance.");
            }
            else
            {
                Balance -= amount;
            }            
        }

        public void Deposit(double amout)
        {
            Balance += amout;
        }

    }
}
