using System;

namespace FLIB
{
    public class AccountNumberCheck
    {
        private int AccountNumber { get; } = 12345678;
        public bool IsAccountActive(int accNum)
        {
            return accNum == AccountNumber;
        }
        
    }
}
