using System;
using FLIB;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccountFacade ba = new BankAccountFacade(12345678, 1234);
            ba.Withdrawn(100);
            ba.Withdrawn(950);

            ba.Deposit(100);
            ba.Withdrawn(200);

        }
    }
}
