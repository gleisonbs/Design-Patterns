using System;

namespace FLIB
{
    public class FundsCheck
    {
        private decimal AccountFunds { get; set; } = 1000.00m;
        public void WithdrawnAccount(decimal withdrawnAmount)
        {
            AccountFunds -= withdrawnAmount;
            Console.WriteLine($"Withdrawn of {withdrawnAmount} complete.");
            Console.WriteLine($"You have {AccountFunds} remaining");
        }

        public void DepositAccount(decimal depositAmount)
        {
            AccountFunds += depositAmount;
            Console.WriteLine($"Deposit of {depositAmount} complete.");
            Console.WriteLine($"You have {AccountFunds} remaining");
        }

        public bool HasEnoughFunds(decimal withdrawnAmount)
        {
            if (withdrawnAmount > AccountFunds) {
                Console.WriteLine($"Insuficcient funds: {withdrawnAmount}");
                return false;
            }
            return true;
        }
    }
}
