using System;
using System.Collections.Generic;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var (a, b) = GetNumbers();
            string operatorSymbol = GetOperatorSymbol();

            CalculateFactory calculateFactory = new CalculateFactory();
            ICalculate calculate = calculateFactory.GetCalculation(operatorSymbol);
            calculate.Calculate(a, b);
        }

        public static (double, double) GetNumbers()
        {
            while (true) 
            {
                Console.Write($"\nEnter the first number: ");
                string n1Str = Console.ReadLine();

                Console.Write($"\nEnter the second number: ");
                string n2Str = Console.ReadLine();

                double n1, n2;
                if (Double.TryParse(n1Str, out n1) && Double.TryParse(n2Str, out n2))
                    return (n1, n2);

                Console.WriteLine("Invalid numbers, try again");
            }
        }

        public static string GetOperatorSymbol()
        {
            HashSet<string> operatorSymbols = new HashSet<string> {"+", "-", "/"};
            while (true) 
            {
                Console.Write($"\nEnter the operator symbol: ");
                string operatorSymbol = Console.ReadLine();

                if (operatorSymbols.Contains(operatorSymbol))
                    return operatorSymbol;

                Console.WriteLine("Invalid operator symbol, try again");
            }
        }
    }
}
