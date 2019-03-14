using System;

namespace FLIB
{
    public class BankAccountFacade
    {
        private int AccountNumber { get; set; }
        private int SecurityCode { get; set; }
        
        AccountNumberCheck accountNumberChecker = new AccountNumberCheck();
        SecurityCodeCheck securityCodeChecker = new SecurityCodeCheck();
        FundsCheck fundsChecker = new FundsCheck();

        DisplayMessage displayMessage = new DisplayMessage();

        public BankAccountFacade(int newAccountNumber, int newSecurityCode)
        {
            AccountNumber = newAccountNumber;
            SecurityCode = newSecurityCode;
        }

        public void Withdrawn(decimal amount)
        {
            if (accountNumberChecker.IsAccountActive(AccountNumber) &&
                securityCodeChecker.IsCodeCorrect(SecurityCode) &&
                fundsChecker.HasEnoughFunds(amount))
            {
                fundsChecker.WithdrawnAccount(amount);
            }
            else
            {
                Console.WriteLine("TransactionFailed");
            }
        }

        public void Deposit(decimal amount)
        {
            if (accountNumberChecker.IsAccountActive(AccountNumber) &&
                securityCodeChecker.IsCodeCorrect(SecurityCode))
            {
                fundsChecker.DepositAccount(amount);
            }
            else
            {
                Console.WriteLine("TransactionFailed");
            }
        }
    }
}
